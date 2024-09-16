using FlexEmulation.Data;
using FlexEmulation.Dtos.Student;
using FlexEmulation.Interfaces;
using FlexEmulation.Mappers;
using FlexEmulation.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace FlexEmulation.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int CalculateRollNo(int id)
        {
            return id * 10;
        }
        public async Task<Student> CreateAsync(Student studentModel)
        {
            await _context.Students.AddAsync(studentModel);
            await _context.SaveChangesAsync();

            studentModel.RollNo = CalculateRollNo(studentModel.Id);

            _context.Students.Update(studentModel);
            await _context.SaveChangesAsync();

            return studentModel;
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
