using System.ComponentModel.DataAnnotations.Schema;

namespace ModelConfigurations.Entities
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
