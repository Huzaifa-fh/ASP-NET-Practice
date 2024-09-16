using System.ComponentModel.DataAnnotations;

namespace FlexEmulation.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Code { get; set; }

        // One Branch can have many Instructors
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
    }
}
