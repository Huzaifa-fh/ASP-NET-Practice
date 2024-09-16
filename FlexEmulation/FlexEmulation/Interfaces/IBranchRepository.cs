using FlexEmulation.Models;

namespace FlexEmulation.Interfaces
{
    public interface IBranchRepository
    {
        Task<Branch> CreateAsync(Branch branchModel);
        Task<List<Branch>> GetAllAsync();
        Task<Branch?> GetByIdAsync(int id);
    }
}
