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
    public class ProductServices : IProductRepositories
    {
        private readonly ApplicationDBContext _dbContext;

        protected ProductServices(ApplicationDBContext dbContext){
            _dbContext = dbContext;
        }

        public async Task Add(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "El producto no puede ser nulo.");
            }

            try
            {
                await _dbContext.Products.AddAsync(product);
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
                var foundProduct = await GetById(id);

                if (foundProduct == null)
                {
                    return false;
                    
                }

                _dbContext.Products.Remove(foundProduct);
                await _dbContext.SaveChangesAsync();
                return true;
              
            }
            catch (Exception ex)
            {
                throw new Exception($"¡Ups! Ocurrio un error {ex.Message}");
            }
            
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            try
            {
                var allProducts = await _dbContext.Products.ToArrayAsync();
                return allProducts;
                
            }
            catch (Exception ex)
            {
                throw new Exception($"¡Ups! Ocurrio un error {ex.Message}");
            }
        }

        public async Task<Product> GetById(int id)
        {
            try
            {
                var FoundProducts = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
                if (FoundProducts == null)
                {
                    return FoundProducts;
                }
                return FoundProducts;
            }
            catch (Exception ex)
            {
                throw new Exception($"¡Ups! Ocurrio un error {ex.Message}");
            }
        }

        public async Task<Product> Update(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "El producto no puede ser nulo.");
            }
            try
            {
                var idProduct = product.Id;
                var productUpdate = await GetById(idProduct);

                if (productUpdate == null)
                {
                    return productUpdate;
                }
                
                productUpdate.Name = product.Name;
                productUpdate.Description = product.Description;
                productUpdate.Price = product.Price;
                productUpdate.Stock = product.Stock;
                productUpdate.CategoryId = product.CategoryId;

                await _dbContext.SaveChangesAsync();
                return productUpdate;
            }
            catch (Exception ex)
            {
                throw new Exception($"¡Ups! Ocurrio un error {ex.Message}");
            }
        }
    }
}