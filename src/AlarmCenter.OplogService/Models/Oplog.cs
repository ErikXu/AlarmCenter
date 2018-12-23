using System;

namespace AlarmCenter.OplogService.Models
{
    public class Oplog
    {
        /// <summary>
        /// 应用Key
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// 事件Id
        /// </summary>
        public string EventId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 告警详情
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public uint Level { get; set; }

        /// <summary>
        /// 主机
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 对象，如具体应用或数据库
        /// </summary>
        public string Entity { get; set; }

        /// <summary>
        /// 日志日期
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}