using System.ComponentModel.DataAnnotations.Schema;

namespace ModelConfigurations.Entities
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }

        [Column("Surname")]
        public string LastName { get; set; }
        public long Age { get; set; }
    }
}














