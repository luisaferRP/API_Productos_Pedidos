using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Data;
using API_Productos_Pedidos.Models;
using API_Productos_Pedidos.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API_Productos_Pedidos.Services
{
    public class CategoryServices(ApplicationDBContext dbContext) : ICategoryRepositories
    {
        private readonly ApplicationDBContext _dbContext = dbContext;

        public async Task Add(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "La categoria no puede ser nulo.");
            }

            try
            {
                _dbContext.Categories.Add(category);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"¡Ups! Ocurrio un error{ex.Message}");
            }  
           
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var foundCategory = await GetById(id);

                if (foundCategory == null)
                {
                    return false;
                    
                }

                _dbContext.Categories.Remove(foundCategory);
                await _dbContext.SaveChangesAsync();

                return true;
              
            }
            catch (Exception ex)
            {
                throw new Exception($"¡Ups! Ocurrio un error {ex.Message}");
            }
           
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            try
            {
                var allCategory = await _dbContext.Categories.ToArrayAsync();
                return allCategory;
                
            }
            catch (Exception ex)
            {
                throw new Exception($"¡Ups! Ocurrio un error {ex.Message}");
            }
            
        }

        public async Task<Category> GetById(int id)
        {
            try
            {
                var FoundProducts = await _dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
                return FoundProducts;
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Ups! Ocurrio un error {ex.Message}");
            }
        }

        public async Task<Category> Update(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "El categoria no puede ser nulo.");
            }
            try
            {
                var idcategory = category.Id;
                var categoryUpdate = await GetById(idcategory);

                if (categoryUpdate == null)
                {
                    return categoryUpdate;
                }

                categoryUpdate.Name = category.Name;
                categoryUpdate.Description = category.Description;

                await _dbContext.SaveChangesAsync();
                return categoryUpdate;
            }
            catch (Exception ex)
            {
                throw new Exception($"¡Ups! Ocurrio un error {ex.Message}");
            }
            
        }
    }
}