using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Controllers.v1.Product;
using API_Productos_Pedidos.DTOS.request;
using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Productos_Pedidos.Controllers.v1.Category
{
    [ApiController]
    [Route("api/v1/category/updateCategory")]
    public class CategoryUpdateControllers(ICategoryRepositories categoryRepositorie) : CategoryControllers(categoryRepositorie)
    {
        [HttpPut]
        [SwaggerOperation(
            Summary = "Update category by id",
            Description ="This endpoint is for update category by id"
        )]
        [SwaggerResponse(200,"category type updated successfully")]
        [SwaggerResponse(400,"An error occurred")]
        [SwaggerResponse(404,"category type not found")]
        public async Task<ActionResult> Update(int id, CategoryDTO category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var foundCategory = await categoryRepositorie.GetById(id);

                if (foundCategory == null)
                {
                    return NotFound("No se encontro la categoria");
                }

                foundCategory.Name = category.Name;
                foundCategory.Description = category.Description;

                await categoryRepositorie.Update(foundCategory);
                return Ok();

            }catch{

                return BadRequest("Ocurrio un error");
            }
        }


    }
}