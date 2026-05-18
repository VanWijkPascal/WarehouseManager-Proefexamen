using Microsoft.EntityFrameworkCore;
using WarehouseManager.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WarehouseManager.Repository
{
    public class WarehouseManagerDbContext(DbContextOptions<WarehouseManagerDbContext> options) : DbContext(options)

    {
        public DbSet<Article> Articles => Set<Article>();

        public DbSet<Warehouse> Warehouses => Set<Warehouse>();

        public void FillInMockData()
        {
            var articlesMockDataList = new List<Article>
            {
                new () { Name = "Gaming Laptop", Description = "A high-performance laptop designed for gaming with a powerful GPU and fast processor." },
                new () { Name = "Wireless Mouse", Description = "An ergonomic wireless mouse with adjustable DPI and long battery life." },
                new () { Name = "Mechanical Keyboard", Description = "A mechanical keyboard with tactile switches and customizable RGB lighting." },
                new () { Name = "4K Monitor", Description = "A 27-inch 4K UHD monitor with vibrant colors and ultra-sharp resolution." },
                new () { Name = "Noise-Cancelling Headphones", Description = "Over-ear headphones with active noise cancellation and premium sound quality." },
                new () { Name = "Smartphone Stand", Description = "An adjustable aluminum stand for smartphones and small tablets." },
                new () { Name = "External SSD", Description = "A portable 1TB solid-state drive with high-speed USB-C connectivity." },
                new () { Name = "Webcam", Description = "A full HD webcam with built-in microphone for video calls and streaming." },
                new () { Name = "Bluetooth Speaker", Description = "A compact portable speaker with deep bass and waterproof design." },
                new () { Name = "USB-C Hub", Description = "A multi-port USB-C hub with HDMI, USB 3.0, and SD card reader support." },
            };

            var warehousesMockDataList = new List<Warehouse>
            {
                new () { Name = "North Logistics Hub", Location = "Antwerp" },
                new () { Name = "Flanders Storage Center", Location = "Ghent" },
                new () { Name = "Wallonia Distribution Depot", Location = "Liège" },
                new () { Name = "Central Freight Warehouse", Location = "Brussels" },
                new () { Name = "Canal Side Storage", Location = "Bruges" },
                new () { Name = "Industrial Park Warehouse", Location = "Charleroi" },
                new () { Name = "EuroPort Supply Hub", Location = "Zeebrugge" },
                new () { Name = "Meuse Valley Storage", Location = "Namur" },
                new () { Name = "Kempen Distribution Center", Location = "Hasselt" },
                new () { Name = "West Coast Logistics", Location = "Ostend" },
            };

            Articles.AddRange(articlesMockDataList);
            Warehouses.AddRange(warehousesMockDataList);

            SaveChanges();
        }
    }
}
