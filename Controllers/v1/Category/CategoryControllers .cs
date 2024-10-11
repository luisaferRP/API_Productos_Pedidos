using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_Productos_Pedidos.Controllers.v1.Category
{
    public class CategoryControllers(ICategoryRepositories categoryRepositories) : ControllerBase
    {
        private readonly ICategoryRepositories _category;
    }
}