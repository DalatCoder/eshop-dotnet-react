using System;
using System.Collections.Generic;
using System.Text;
using eShopSolutionReact.EF.Enums;

namespace eShopSolutionReact.EF.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public string? Title { set; get; }

        public List<Product>? Products { get; set; }
    }
}
