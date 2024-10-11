using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Models;

namespace API_Productos_Pedidos.Repositories
{
    public interface IProductRepositories
    {
        Task<IEnumerable<Product>> GetAll();

        Task<Product> GetById(int id);

        Task Add(Product product);

        Task<Product> Update(Product product);

        Task <bool> Delete(int id);  

        //Task<IEnumerable<Product>> CheckExistence(int id);      
    }
}