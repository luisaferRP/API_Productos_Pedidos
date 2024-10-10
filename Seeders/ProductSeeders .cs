using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Productos_Pedidos.Seeders
{
    public class ProductSeeders
    {
        public static void SeedP(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Smartphone",
                    Description = "Latest model smartphone with 5G support",
                    Price = 699.99,
                    Stock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Laptop",
                    Description = "High performance laptop for gaming",
                    Price = 999.99,
                    Stock = 30,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "T-shirt",
                    Description = "100% cotton T-shirt available in various colors",
                    Price = 10.99,
                    Stock = 100,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 4,
                    Name = "Jeans",
                    Description = "Comfortable blue jeans, available in multiple sizes",
                    Price = 39.99,
                    Stock = 50,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 5,
                    Name = "Furniture",
                    Description = "leather furniture",
                    Price = 210.99,
                    Stock = 20,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Name = "Mirror",
                    Description = "large round mirror",
                    Price = 20.50,
                    Stock = 85,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Name = "Headphones",
                    Description = "Noise-cancelling headphones with Bluetooth",
                    Price = 149.99,
                    Stock = 40,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 8,
                    Name = "Jacket",
                    Description = "Winter jacket to keep you warm",
                    Price = 89.99,
                    Stock = 25,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 9,
                    Name = "Refrigerator",
                    Description = "Large black refrigerator",
                    Price = 234.200,
                    Stock = 18,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 10,
                    Name = "Bed",
                    Description = "Extra large bed",
                    Price = 120.50,
                    Stock = 12,
                    CategoryId = 2
                }

            );

        }

    }
}