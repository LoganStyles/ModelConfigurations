using System.ComponentModel.DataAnnotations.Schema;

namespace ModelConfigurations.Entities
{
    [Table("Artists")]
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Age { get; set; }
    }
}
