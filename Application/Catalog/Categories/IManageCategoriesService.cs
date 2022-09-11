using eShopSolutionReact.ViewModels.Catalog.Categories;
using eShopSolutionReact.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolutionReact.Application.Catalog.Categories
{
    public interface IManageCategoriesService
    {
        Task<List<CategoryViewModel>> GetAll();
        Task<PagedResult<CategoryViewModel>> GetAllPagination(CategoryManageRequest request);
    }
}
