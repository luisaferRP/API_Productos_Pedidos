using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Models;
using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Productos_Pedidos.Controllers.v1.Category
{
    [ApiController]
    [Route("api/v1/category")]
    public class CategoryDeleteControllers(ICategoryRepositories categoryRepositories) : CategoryControllers(categoryRepositories)
    {
        [HttpDelete("/{id}")]
        [SwaggerOperation(
            Summary = "Delete category by id",
            Description ="This endpoint is for delete category  by id"
        )]
        [SwaggerResponse(200,"category deleted successfully")]
        [SwaggerResponse(400,"An error occurred")]
        [SwaggerResponse(404,"category not found")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var foundProduct = await categoryRepositories.Delete(id);
                if (foundProduct == false)
                {
                    return NotFound("No se encontró la categoria");
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