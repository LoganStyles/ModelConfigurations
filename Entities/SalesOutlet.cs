using System.ComponentModel.DataAnnotations.Schema;

namespace ModelConfigurations.Entities
{
    public class SalesOutlet
    {
        public long Id { get; set; }
        public string Title { get; set; }
        
        [NotMapped]
        public string Address { get; set; }
    }
}
