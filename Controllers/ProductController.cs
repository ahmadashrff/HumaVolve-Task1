using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using HumaVolve_Task1.DataSimulation;
using HumaVolve_Task1.Model;

namespace HumaVolve_Task1.Controllers
{
    [Route("api/v{version:apiVersion}/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllProducts")]
        [ApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Product>> GetAllProductsV1()
        {
            if (ProductDataSimulation.Products.Count == 0)
                return NotFound("No Students Found!");

            var products = ProductDataSimulation.Products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Price
            }).ToList();

            return Ok(products);
        }

        [HttpGet("All", Name = "GetAllProductsV2")]
        [ApiVersion("2.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Product>> GetAllProductsV2()
        {
            if (ProductDataSimulation.Products.Count == 0)
                return NotFound("No Students Found!");

            return Ok(ProductDataSimulation.Products);
        }
    }
}
