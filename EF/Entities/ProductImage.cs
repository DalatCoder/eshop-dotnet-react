using System;
using System.Collections.Generic;
using System.Text;
using eShopSolutionReact.EF.Enums;

namespace eShopSolutionReact.EF.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? ImagePath { get; set; }
        public string? Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }

        public Product? Product { get; set; }
    }
}
