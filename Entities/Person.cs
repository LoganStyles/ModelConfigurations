using System.ComponentModel.DataAnnotations;

namespace ModelConfigurations.Entities
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
