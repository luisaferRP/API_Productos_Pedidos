using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_Productos_Pedidos.Controllers.v1.Product
{
    [ApiController]
    [Route("api/v1/delete")]
    public class ProductDeleteControllers(IProductRepositories productRepositories) : ProductControllers(productRepositories)
    {
        [HttpDelete("/{id}")]
        [SwaggerOperation(
            Summary = "Delete Product by id",
            Description ="This endpoint is for delete Product  by id"
        )]
        [SwaggerResponse(200,"Product deleted successfully")]
        [SwaggerResponse(400,"An error occurred")]
        [SwaggerResponse(404,"Product not found")]
        public async Task<OkResult> Delete(int id)
        {
            try
            {
                var foundProduct = await productRepositories.Delete(id);
                if (foundProduct == false)
                {
                    return NotFound("No se encontró el producto");
                }

                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }
    }
}