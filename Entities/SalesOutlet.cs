using System.ComponentModel.DataAnnotations.Schema;

namespace ModelConfigurations.Entities
{
    [NotMapped]
    public class SalesOutlet
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
    }
}
