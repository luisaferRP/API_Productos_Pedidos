using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Productos_Pedidos.Seeders
{
    public class CategorieSeeders
    {
        public static void SeedersC(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Electronics",
                    Description = "Devices and gadgets"
                },
                new Category
                {
                    Id = 2,
                    Name = "Home",
                    Description = "Things for the home"
                },
                new Category
                {
                    Id = 3,
                    Name = "Clothing",
                    Description = "Men's and women's clothing"
                }
            );
        }

    }
}