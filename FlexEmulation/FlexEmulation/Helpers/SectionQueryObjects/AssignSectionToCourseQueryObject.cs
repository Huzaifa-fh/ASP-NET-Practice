using System.ComponentModel.DataAnnotations;

namespace FlexEmulation.Helpers.SectionQueryObjects
{
    public class AssignSectionToCourseQueryObject
    {
        [Required]
        public int SectionId { get; set; }
        [Required]
        public int CourseId { get; set; }
    }
}
