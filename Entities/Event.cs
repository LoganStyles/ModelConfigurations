using Microsoft.EntityFrameworkCore;

namespace ModelConfigurations.Entities
{
    [Comment("Events for the year")]
    public class Event
    {
        public long EventId { get; set; }
        public long ScheduleId { get; set; }
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
    }
}
