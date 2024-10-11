using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_Productos_Pedidos.Controllers.v1.Product
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductGetControllers(IProductRepositories productRepositories) : ProductControllers(productRepositories)
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Product>>> GetAll()
        {
            try
            {
                var all = await productRepositories.GetAll();
                if (all.Any())
                {
                    return Ok(all);
                }
                return NotFound("Dato no encontrado");
            }
            catch
            {
                return BadRequest("Ups, ocurrio un error");
            }

        }
    }
}