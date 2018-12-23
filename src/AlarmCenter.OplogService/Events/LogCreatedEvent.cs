using AlarmCenter.OplogService.Models;

namespace AlarmCenter.OplogService.Events
{
    public class LogCreatedEvent
    {
        public Oplog Oplog { get; set; }
    }
}