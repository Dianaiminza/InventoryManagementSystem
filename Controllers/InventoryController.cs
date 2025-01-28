using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryController(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        // GET: api/inventory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetInventoryItems()
        {
            var items = await _inventoryRepository.GetAllItemsAsync();
            return Ok(items);
        }

        // GET: api/inventory/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryItem>> GetInventoryItem(int id)
        {
            var item = await _inventoryRepository.GetItemByIdAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // POST: api/inventory
        [HttpPost]
        public async Task<ActionResult<InventoryItem>> PostInventoryItem(InventoryItem item)
        {
            await _inventoryRepository.AddItemAsync(item);
            return CreatedAtAction(nameof(GetInventoryItem), new { id = item.Id }, item);
        }

        // PUT: api/inventory/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryItem(int id, InventoryItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            await _inventoryRepository.UpdateItemAsync(item);
            return NoContent();
        }

        // DELETE: api/inventory/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventoryItem(int id)
        {
            await _inventoryRepository.DeleteItemAsync(id);
            return NoContent();
        }
    }
}
