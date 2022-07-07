using Microsoft.EntityFrameworkCore;

namespace ModelConfigurations.Entities
{
    [Comment("Events for the year")]
    public class Event
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
    }
}















