using FlexEmulation.Dtos.Instructor;
using FlexEmulation.Models;

namespace FlexEmulation.Interfaces
{
    public interface IInstructorRepository
    {
        Task<Instructor> CreateAsync(Instructor instructorModel);
        Task<Instructor?> GetByIdAsync(int id);
        Task<Instructor> AssignBranchAsync(Instructor instructorModel, Branch branchModel);
    }
}
