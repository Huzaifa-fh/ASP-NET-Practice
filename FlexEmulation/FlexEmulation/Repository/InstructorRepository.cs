using FlexEmulation.Data;
using FlexEmulation.Dtos.Instructor;
using FlexEmulation.Interfaces;
using FlexEmulation.Mappers;
using FlexEmulation.Models;
using Microsoft.EntityFrameworkCore;

namespace FlexEmulation.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly ApplicationDbContext _context;
        public InstructorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Instructor> CreateAsync(Instructor instructorModel)
        {
            await _context.Instructors.AddAsync(instructorModel);
            await _context.SaveChangesAsync();
            return instructorModel;
        }

        public async Task<Instructor> AssignBranchAsync(Instructor instructorModel, Branch branchModel)
        {
            instructorModel.BranchId = branchModel.Id;
            instructorModel.Branch = branchModel;

            if (!branchModel.Instructors.Contains(instructorModel))
            {
                branchModel.Instructors.Add(instructorModel);
            }

            await _context.SaveChangesAsync();
            return instructorModel;
        }

        public async Task<Instructor?> GetByIdAsync(int id)
        {
            return await _context.Instructors.FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}
