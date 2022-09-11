using eShopSolutionReact.Application.Catalog.Categories;
using eShopSolutionReact.ViewModels.Catalog.Categories;
using eShopSolutionReact.Utilities.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eShopSolutionReact.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IManageCategoriesService _manageCategoryService;
        public CategoriesController(IManageCategoriesService manageCategoryService)
        {
            _manageCategoryService = manageCategoryService;
        }

        [HttpGet()]
        public async Task<IActionResult> Get([FromQuery] CategoryManageRequest request)
        {
            if (request.PageIndex == 0) request.PageIndex = 1;
            if (request.PageSize == 0) request.PageSize = 10;

            var result = await _manageCategoryService.GetAllPagination(request);

            var response = ResponseHelper.GetOkStructure(new
            {
                items = result.Items,
                currentPage = request.PageIndex,
                limit = request.PageSize,
                totalRecords = result.TotalRecord,
            });
            return Ok(response);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _manageCategoryService.GetAll();
            var response = ResponseHelper.GetOkStructure(new { items = categories, count = categories.Count });
            return Ok(response);
        }
    }
}
