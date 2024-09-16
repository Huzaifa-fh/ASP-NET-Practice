using FlexEmulation.Models;

namespace FlexEmulation.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllAsync();
        Task<Course> CreateAsync(Course courseModel);
        Task<Course?> GetByIdAsync(int id);
    }
}
