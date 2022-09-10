using eShopSolutionReact.ViewModels.Catalog.Products;
using eShopSolutionReact.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolutionReact.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}
