using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolutionReact.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }

        public string? Name { set; get; }
        public string? Description { set; get; }
        public IFormFile? ThumbnailImage { get; set; }
    }
}
