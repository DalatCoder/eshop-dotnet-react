using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolutionReact.EF.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public Guid UserId { get; set; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public DateTimeOffset DateCreated { get; set; }

        public Product? Product { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
