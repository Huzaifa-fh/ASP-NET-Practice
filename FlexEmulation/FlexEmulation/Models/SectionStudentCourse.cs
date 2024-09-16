using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlexEmulation.Models
{
    public class SectionStudentCourse
    {
        [Key]
        public int Id { get; set; }

        // Foreign key for Student
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

        public int SectionCourseId { get; set; }
        [ForeignKey("SectionCourseId")]
        public SectionCourse? SectionCourse { get; set; }
    }
}
