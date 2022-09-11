using eShopSolutionReact.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolutionReact.ViewModels.Catalog.Categories
{
    public class CategoryManageRequest : PagingRequestBase
    {
        public string? Keyword { get; set; }
    }
}
