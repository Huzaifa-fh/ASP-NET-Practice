using System.ComponentModel.DataAnnotations;

namespace FlexEmulation.Dtos.Section
{
    public class CreateSectionDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Section name should be less than 10 character")]
        public string? Name { get; set; }
    }
}
