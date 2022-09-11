using System;
using System.Collections.Generic;
using System.Text;
using eShopSolutionReact.EF.Enums;

namespace eShopSolutionReact.EF.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public string? Description { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTimeOffset DateCreated { set; get; }

        public int CategoryId { set; get; }
        public Category? Category { get; set; }

        public List<Cart>? Carts { set; get; }
        public List<ProductImage>? ProductImages { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
