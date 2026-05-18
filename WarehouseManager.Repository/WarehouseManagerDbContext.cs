using Microsoft.EntityFrameworkCore;
using WarehouseManager.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WarehouseManager.Repository
{
    public class WarehouseManagerDbContext : DbContext

    {
        public DbSet<Article> Articles => Set<Article>();

        public DbSet<Warehouse> Warehouses => Set<Warehouse>();

        public void MockData()
        {

        }
    }
}
