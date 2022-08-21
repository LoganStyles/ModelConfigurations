namespace ModelConfigurations.Entities
{
    public class Event
    {
        public long Id { get; set; }

        public long EventId { get; set; }
        
        public string Title { get; set; }

        public DateTime EventDate { get; set; }
    }
}
