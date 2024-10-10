using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Models;
using Microsoft.EntityFrameworkCore;
using API_Productos_Pedidos.Seeders;

namespace API_Productos_Pedidos.Data
{
    public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<OrderProduct> OrderProducts{ get; set; }
        public DbSet<User> Users{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            CategorieSeeders.SeedersC(modelBuilder);
            ProductSeeders.SeedP(modelBuilder);
        }
    }
}