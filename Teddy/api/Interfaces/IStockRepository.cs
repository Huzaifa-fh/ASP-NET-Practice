using api.Dtos.Stocks;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stocks>> GetAllAsync(StockQueryObject query);
        Task<Stocks?> GetByIdAsync(int id);
        Task<Stocks?> GetBySymbol(string symbol);
        Task<Stocks?> UpdateAsync(int id, UpdateStockDto stockModel);
        Task<Stocks> CreateAsync(Stocks stockModel);
        Task<Stocks?> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}
