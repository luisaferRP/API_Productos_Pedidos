using API_Productos_Pedidos.DTOS.request;
using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Productos_Pedidos.Controllers.v1.Category
{
    [ApiController]
    [Route("api/v1/category/create")]
    public class CategoryCreateControllers(ICategoryRepositories categoryRepositories) : CategoryControllers(categoryRepositories)
    {
        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a new category",
            Description ="This endpoint is for create a new category"
        )]
        [SwaggerResponse(201,"category created successfully")]
        [SwaggerResponse(400,"An error occurred")]
        public async Task<ActionResult<Models.Category>> Create(CategoryDTO category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var newCategory = new Models.Category{
                    Name = category.Name,
                    Description = category.Description
                };
                await categoryRepositories.Add(newCategory);
                return Ok(category);
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }

    }
}