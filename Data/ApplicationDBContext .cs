using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Productos_Pedidos.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<OrderProduct> OrderProducts{ get; set; }
        public DbSet<User> Users{ get; set; }

        public ApplicationDBContext(DbContextOptions options) : base(options){}
    }
}