using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services.Abstractions
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<InventoryItem>> GetAllItemsAsync();
        Task<InventoryItem> GetItemByIdAsync(int id);
        Task AddItemAsync(InventoryItem item);
        Task UpdateItemAsync(InventoryItem item);
        Task DeleteItemAsync(int id);
    }
}
