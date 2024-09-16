namespace FlexEmulation.Dtos.Instructor
{
    public class InstructorDto
    {
        public string Name { get; set; } = string.Empty; // Instructor's name
        public string Email { get; set; } = string.Empty; // Instructor's email
        public string PhoneNumber { get; set; } = string.Empty; // Instructor's phone number

        // Branch details
        public int? BranchId { get; set; } // Foreign key reference to Branch
        public string? BranchName { get; set; } // Branch name
    }
}
