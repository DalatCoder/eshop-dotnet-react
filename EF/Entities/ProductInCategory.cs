using System;
using System.Collections.Generic;
using System.Text;
using eShopSolutionReact.EF.Enums;

namespace eShopSolutionReact.EF.Entities
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
