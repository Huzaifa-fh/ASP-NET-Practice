using FlexEmulation.Data;
using FlexEmulation.Interfaces;
using FlexEmulation.Models;
using Microsoft.EntityFrameworkCore;

namespace FlexEmulation.Repository
{
    public class SectionRepository : ISectionRepository
    {
        private readonly ApplicationDbContext _context;
        public SectionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Section> CreateAsync(Section sectionModel)
        {
            await _context.Sections.AddAsync(sectionModel);
            await _context.SaveChangesAsync();
            
            return sectionModel;
        }

        public async Task<List<Section>> GetAllAsync()
        {
            return await _context.Sections.ToListAsync();
        }

        public async Task<Section?> GetByIdAsync(int id)
        {
            return await _context.Sections.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
