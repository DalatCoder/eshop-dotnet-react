using System;
using System.Collections.Generic;
using System.Text;
using eShopSolutionReact.EF.Enums;

namespace eShopSolutionReact.EF.Entities
{
    public class Order
    {
        public int Id { set; get; }
        public DateTimeOffset OrderDate { set; get; }
        public Guid UserId { set; get; }
        public string? ShipName { set; get; }
        public string? ShipAddress { set; get; }
        public string? ShipEmail { set; get; }
        public string? ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }

        public List<OrderDetail>? OrderDetails { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
