using FlexEmulation.Models;
namespace FlexEmulation.Interfaces

{
    public interface ISectionRepository
    {
        Task<List<Section>> GetAllAsync();
        Task<Section> CreateAsync(Section sectionModel);
        Task<Section?> GetByIdAsync(int id);
    }
}
