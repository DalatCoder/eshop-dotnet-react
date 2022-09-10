using eShopSolutionReact.ViewModels.Catalog.Products;
using eShopSolutionReact.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolutionReact.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest product);

        Task<int> Update(ProductUpdateRequest product);

        Task<bool> UpdatePrice(int productId, int newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

        Task<int> Delete(int id);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
