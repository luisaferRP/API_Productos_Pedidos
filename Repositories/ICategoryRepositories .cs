using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Models;

namespace API_Productos_Pedidos.Repositories
{
    public interface ICategoryRepositories 
    {
        Task<IEnumerable<Category>> GetAll();

        Task<Category> GetById(int id);

        Task Add(Category category);

        Task<Category> Update(Category category);

        Task <bool> Delete(int id);   
        
    }
}