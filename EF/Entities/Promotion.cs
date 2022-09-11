using System;
using System.Collections.Generic;
using System.Text;
using eShopSolutionReact.EF.Enums;

namespace eShopSolutionReact.EF.Entities
{
    public class Promotion
    {
        public int Id { set; get; }
        public DateTimeOffset FromDate { set; get; }
        public DateTimeOffset ToDate { set; get; }
        public bool ApplyForAll { set; get; }
        public int? DiscountPercent { set; get; }
        public decimal? DiscountAmount { set; get; }
        public string? ProductIds { set; get; }
        public string? ProductCategoryIds { set; get; }
        public Status Status { set; get; }
        public string? Name { set; get; }
    }
}
