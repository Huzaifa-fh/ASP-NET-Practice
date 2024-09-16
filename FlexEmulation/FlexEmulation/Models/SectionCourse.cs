using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlexEmulation.Models
{
    public class SectionCourse
    {
        [Key]
        public int Id { get; set; }
        public int SectionId { get; set; }
        [ForeignKey("SectionId")]
        public Section? Section { get; set; }

        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

        public ICollection<SectionCourseInstructor> SectionCourseInstructors { get; set; } = new List<SectionCourseInstructor>();
        public ICollection<SectionStudentCourse> SectionStudentCourses { get; set; } = new List<SectionStudentCourse>();
    }
}
