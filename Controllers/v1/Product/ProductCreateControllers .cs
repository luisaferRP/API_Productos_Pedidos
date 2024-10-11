using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;
using  API_Productos_Pedidos.Models;
using Swashbuckle.AspNetCore.Annotations;
using API_Productos_Pedidos.DTOS.request;

namespace API_Productos_Pedidos.Controllers.v1.Product
{
    [ApiController]
    [Route("api/v1/create/")]
    public class ProductCreateControllers(IProductRepositories productRepositories) : ProductControllers(productRepositories)
    {
        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a new product",
            Description ="This endpoint is for create a new product"
        )]
        [SwaggerResponse(201,"product created successfully")]
        [SwaggerResponse(400,"An error occurred")]
        public async Task<ActionResult<Models.Product>> Create(ProductDTO product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var newProduct = new Models.Product{
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                    CategoryId = product.CategoryId
                };
                await productRepositories.Add(newProduct);
                return Ok(product);
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }
    }
}