using FlexEmulation.Dtos.Instructor;
using FlexEmulation.Models;

namespace FlexEmulation.Mappers
{
    public static class InstructorMappers
    {
        public static Instructor ToInstructorModelFromCreateDto(this CreateInstructorDto instructorDto)
        {
            return new Instructor
            {
                Name = instructorDto.Name,
                Email = instructorDto.Email,
                PhoneNumber = instructorDto.PhoneNumber
            };
        }

        public static InstructorDto ToInstructorDto(this Instructor instructor)
        {
            return new InstructorDto
            {
                Name = instructor.Name,
                Email = instructor.Email,
                PhoneNumber = instructor.PhoneNumber,
                BranchId = instructor.BranchId,
                BranchName = instructor.Branch?.Name
            };
        }
    }
}
