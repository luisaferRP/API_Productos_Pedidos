using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Productos_Pedidos.Controllers.v1.Product
{
    [ApiController]
    [Route("api/v1/product")]
    public class ProductGetControllers(IProductRepositories productRepositories) : ProductControllers(productRepositories)
    {
        [HttpGet]
        [SwaggerOperation(
            Summary = "Get all product ",
            Description ="This endpoint is for get all product"
        )]
        [SwaggerResponse(200,"Get all product")]
        [SwaggerResponse(400,"An error occurred")]
        [SwaggerResponse(404,"data not found")]
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

        [HttpGet("/{id}")]
        [SwaggerOperation(
            Summary = "Get for id product",
            Description ="This endpoint is for get for id product"
        )]
        [SwaggerResponse(200,"Get product by id is successful")]
        [SwaggerResponse(400,"An error occurred")]
        [SwaggerResponse(404,"User not found")]
        public async Task<ActionResult<Models.Product>> GetById(int id)
        {
            try
            {
                var foundProductById = await productRepositories.GetById(id);

                if (foundProductById == null ) 
                {
                    return NotFound("El tipo de product con el ID ingresado no existe.");
                }
                return Ok(foundProductById);
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }
    }
}