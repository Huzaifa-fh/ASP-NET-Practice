using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlexEmulation.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        // One Instructor can have many Courses
        public ICollection<SectionCourseInstructor> SectionCourseInstructors { get; set; } = new List<SectionCourseInstructor>();

        // One Instructor belongs to one Branch
        public int? BranchId { get; set; }
        [ForeignKey("BranchId")]
        public Branch? Branch { get; set; }
    }
}
