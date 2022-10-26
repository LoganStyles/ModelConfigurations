using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace ModelConfigurations.Models.Entities{

    public class Department{

        public long Id { get; set; }

        [Column("Name")]
        public string Title { get; set; }

        [Comment("Head of Department")]
        public string HOD { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}