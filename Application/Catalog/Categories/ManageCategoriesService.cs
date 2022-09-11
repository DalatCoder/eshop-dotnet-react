using eShopSolutionReact.Application.Common;
using eShopSolutionReact.EF;
using eShopSolutionReact.EF.Entities;
using eShopSolutionReact.Utilities.Exceptions;
using eShopSolutionReact.ViewModels.Catalog.Categories;
using eShopSolutionReact.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eShopSolutionReact.Application.Catalog.Categories
{
    public class ManageCategoriesService : IManageCategoriesService
    {
        private readonly EShopDbContext _context;

        public ManageCategoriesService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            return await _context
            .Categories
            .Select(x => new CategoryViewModel()
            {
                Id = x.Id,
                Title = x.Title
            })
            .ToListAsync();
        }

        public async Task<PagedResult<CategoryViewModel>> GetAllPagination(CategoryManageRequest request)
        {
            if (request.PageIndex == 0)
                request.PageIndex = 1;

            if (request.PageSize == 0)
                request.PageSize = 10;

            var skip = (request.PageIndex - 1) * request.PageSize;

            var count = await _context.Categories.CountAsync();

            var categories = await _context
                .Categories
                .Skip(skip)
                .Take(request.PageSize)
                .Select(x => new CategoryViewModel()
                {
                    Id = x.Id,
                    Title = x.Title
                })
                .ToListAsync();

            var result = new PagedResult<CategoryViewModel>()
            {
                Items = categories,
                TotalRecord = count
            };

            return result;
        }
    }
}
