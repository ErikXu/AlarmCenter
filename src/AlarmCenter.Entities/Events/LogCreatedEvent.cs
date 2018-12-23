using AlarmCenter.Entities.Models;

namespace AlarmCenter.Entities.Events
{
    public class LogCreatedEvent
    {
        public Oplog Oplog { get; set; }
    }
}