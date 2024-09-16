using static System.Collections.Specialized.BitVector32;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlexEmulation.Models
{
    public class SectionCourseInstructor
    {
        [Key]
        public int Id { get; set; }

        public int InstructorId { get; set; }
        [ForeignKey("InstructorId")]
        public Instructor? Instructor { get; set; }

        public int SectionCourseId { get; set; }
        [ForeignKey("SectionCourseId")]
        public SectionCourse? SectionCourse { get; set; }
    }
}
