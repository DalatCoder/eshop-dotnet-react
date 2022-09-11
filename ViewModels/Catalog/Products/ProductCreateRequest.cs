using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolutionReact.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public string? Name { set; get; }
        public string? Description { set; get; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }

        public IFormFile? ThumbnailImage { get; set; }
    }
}
