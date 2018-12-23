using System.ComponentModel.DataAnnotations;

namespace AlarmCenter.OplogService.Models
{
    public class CreateForm
    {
        /// <summary>
        /// 应用Key
        /// </summary>
        [Required]
        public string AppKey { get; set; }

        /// <summary>
        /// 事件Id
        /// </summary>
        [Required]
        public string EventId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 告警详情
        /// </summary>
        [Required]
        public string Content { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        [Required]
        public uint Level { get; set; }

        /// <summary>
        /// 主机
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 对象，如具体应用或数据库
        /// </summary>
        public string Entity { get; set; }
    }
}