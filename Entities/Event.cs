using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelConfigurations.Entities
{
    public class Event
    {
        public long Id { get; set; }

        [Key]
        public long EventId { get; set; }
        
        public string Title { get; set; }

        [Comment("The date of the event")]
        public DateTime EventDate { get; set; }
    }
}














