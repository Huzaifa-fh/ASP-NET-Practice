using System.ComponentModel.DataAnnotations;

namespace FlexEmulation.Dtos.Course
{
    public class CreateCourseDto
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name must be less than 100 characters")]
        [MinLength(3, ErrorMessage = "Name must have at least 3 characters")]
        public string? Name { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Code must be less than 100 characters")]
        [MinLength(3, ErrorMessage = "Code must have at least 3 characters")]
        public string? Code { get; set; }
    }
}
