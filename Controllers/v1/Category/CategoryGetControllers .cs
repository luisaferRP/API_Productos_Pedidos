using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Controllers.v1.Product;
using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Productos_Pedidos.Controllers.v1.Category
{
    [ApiController]
    [Route("api/v1/category")]
    public class CategoryGetControllers(ICategoryRepositories categoryRepositories) : CategoryControllers(categoryRepositories)
    {
        [HttpGet]
        [SwaggerOperation(
            Summary = "Get all category ",
            Description ="This endpoint is for get all category"
        )]
        [SwaggerResponse(200,"Get all category")]
        [SwaggerResponse(400,"An error occurred")]
        [SwaggerResponse(404,"data not found")]
        public async Task<ActionResult<IEnumerable<Models.Category>>> GetAll()
        {
            try
            {
                var all = await categoryRepositories.GetAll();
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
            Summary = "Get for id category",
            Description ="This endpoint is for get for id category"
        )]
        [SwaggerResponse(200,"Get category by id is successful")]
        [SwaggerResponse(400,"An error occurred")]
        [SwaggerResponse(404,"User not found")]
        public async Task<ActionResult<Models.Product>> GetById(int id)
        {
            try
            {
                var foundCategoryById = await categoryRepositories.GetById(id);

                if (foundCategoryById == null ) 
                {
                    return NotFound("la categoria con el ID ingresado no existe.");
                }
                return Ok(foundCategoryById);
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }

    }
}