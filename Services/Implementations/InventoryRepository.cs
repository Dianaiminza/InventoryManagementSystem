using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Services.Implementations
{
    public class InventoryRepository: IInventoryRepository
    {
        private readonly ApplicationDbContext _context;

        public InventoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InventoryItem>> GetAllItemsAsync() =>
            await _context.InventoryItems.Include(i => i.Category).Include(i => i.Supplier).ToListAsync();

        public async Task<InventoryItem> GetItemByIdAsync(int id) =>
            await _context.InventoryItems.Include(i => i.Category).Include(i => i.Supplier)
                .FirstOrDefaultAsync(i => i.Id == id);

        public async Task AddItemAsync(InventoryItem item)
        {
            _context.InventoryItems.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateItemAsync(InventoryItem item)
        {
            _context.InventoryItems.Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteItemAsync(int id)
        {
            var item = await _context.InventoryItems.FindAsync(id);
            if (item != null)
            {
                _context.InventoryItems.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
