using FlexEmulation.Dtos.Student;
using FlexEmulation.Models;

namespace FlexEmulation.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student> CreateAsync(Student studentModel);
        Task<Student?> GetByIdAsync(int id);
    }
}
