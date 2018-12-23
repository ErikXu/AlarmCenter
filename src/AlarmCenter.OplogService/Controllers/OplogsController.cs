using System;
using AlarmCenter.OplogService.Events;
using AlarmCenter.OplogService.Models;
using AlarmCenter.Utils.Conversion;
using AlarmCenter.Utils.Serialization;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;

namespace AlarmCenter.OplogService.Controllers
{
    [Route("api/oplogs")]
    [ApiController]
    public class OplogsController : ControllerBase
    {
        private readonly IConnection _rabbitConnection;
        private readonly IMapper _mapper;
        private readonly IJsonUtil _jsonUtil;

        private const string LogCreatedExchange = "LogCreated";

        public OplogsController(IConnection rabbitConnection, IMapper mapper, IJsonUtil jsonUtil)
        {
            _rabbitConnection = rabbitConnection;
            _mapper = mapper;
            _jsonUtil = jsonUtil;
        }

        /// <summary>
        /// 日志上报
        /// </summary>
        /// <param name="form">日志表单</param>
        [HttpPost]
        public IActionResult Create([FromBody] CreateForm form)
        {
            var oplog = _mapper.Map<Oplog>(form);
            oplog.Timestamp = DateTime.UtcNow;
            Send(oplog);

            return Ok();
        }

        private void Send(Oplog oplog)
        {
            using (var channel = _rabbitConnection.CreateModel())
            {
                channel.ExchangeDeclare(LogCreatedExchange, "fanout", true);

                var properties = channel.CreateBasicProperties();
                properties.Persistent = true;
                properties.MessageId = Guid.NewGuid().ToString("N");
                properties.Timestamp = new AmqpTimestamp(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

                var logCreatedEvent = new LogCreatedEvent
                {
                    Oplog = oplog
                };

                var json = _jsonUtil.SerializeObject(logCreatedEvent);
                channel.BasicPublish(LogCreatedExchange, string.Empty, properties, json.StringToBytes());
            }
        }
    }
}
