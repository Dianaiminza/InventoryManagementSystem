using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryManagementSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }

}
