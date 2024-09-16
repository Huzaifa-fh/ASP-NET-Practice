using FlexEmulation.Dtos.Student;
using FlexEmulation.Models;

namespace FlexEmulation.Mappers
{
    public static class StudentMappers
    {
        public static StudentDto ToStudentDto(this Student student)
        {
            return new StudentDto
            {
                Name = student.Name,
                Email = student.Email,
                PhoneNumber = student.PhoneNumber
            };
        }
        public static Student ToStudentModelFromCreateDto(this CreateStudentDto studentDto)
        {
            return new Student
            {
                Name = studentDto.Name,
                Email = studentDto.Email,
                PhoneNumber = studentDto.PhoneNumber
            };
        }
    }
}
