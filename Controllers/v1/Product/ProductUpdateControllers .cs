using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Productos_Pedidos.DTOS.request;
using API_Productos_Pedidos.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Productos_Pedidos.Controllers.v1.Product
{
    [ApiController]
    [Route("api/v1/product")]
    public class ProductUpdateControllers(IProductRepositories productRepositories) : ProductControllers(productRepositories)
    {
        [HttpPut("/updateProduct")]
        [SwaggerOperation(
            Summary = "Update Product by id",
            Description ="This endpoint is for update Product by id"
        )]
        [SwaggerResponse(200,"Product type updated successfully")]
        [SwaggerResponse(400,"An error occurred")]
        [SwaggerResponse(404,"Product type not found")]
        public async Task<ActionResult> Update(int id, ProductDTO product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var foundProduct = await productRepositories.GetById(id);

                if (foundProduct == null)
                {
                    return NotFound("No se encontró el producto");
                }

                foundProduct.Name = product.Name;
                foundProduct.Description = product.Description;
                foundProduct.Price = product.Price;
                foundProduct.Stock = product.Stock;
                foundProduct.CategoryId = product.CategoryId;

                await productRepositories.Update(foundProduct);
                return Ok();

            }catch{

                return BadRequest("Ocurrio un error");
            }
        }
    }
}