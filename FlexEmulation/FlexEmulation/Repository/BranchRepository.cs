using FlexEmulation.Data;
using FlexEmulation.Interfaces;
using FlexEmulation.Models;
using Microsoft.EntityFrameworkCore;

namespace FlexEmulation.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private readonly ApplicationDbContext _context;
        public BranchRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Branch> CreateAsync(Branch branchModel)
        {
            await _context.Branches.AddAsync(branchModel);
            await _context.SaveChangesAsync();
            return branchModel;
        }

        public async Task<List<Branch>> GetAllAsync()
        {
            var branches = await _context.Branches.ToListAsync();
            return branches;
        }

        public async Task<Branch?> GetByIdAsync(int id)
        {
            return await _context.Branches.Include(i => i.Instructors).FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
