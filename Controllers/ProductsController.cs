using eShopSolutionReact.Application.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using eShopSolutionReact.Utilities.Http;

namespace eShopSolutionReact.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        public ProductsController(IPublicProductService publicProductService)
        {
            _publicProductService = publicProductService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _publicProductService.GetAll();
            var response = ResponseHelper.GetOkStructure(new { items = products, length = products.Count });
            return Ok(response);
        }
    }
}
