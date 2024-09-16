using System.ComponentModel.DataAnnotations;

namespace FlexEmulation.Dtos.Branch
{
    public class CreateBranchDto
    {
        [Required]
        [MinLength(1, ErrorMessage = "Name should be greater than 1 character")]
        [MaxLength(50, ErrorMessage = "Name should be less than 50 characters")]
        public string? Name { get; set; }
        [Required]
        public int Code { get; set; }

    }
}
