using System;
using System.Collections.Generic;
using System.Text;
using eShopSolutionReact.EF.Enums;

namespace eShopSolutionReact.EF.Entities
{
    public class Contact
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public string? Email { set; get; }
        public string? PhoneNumber { set; get; }
        public string? Message { set; get; }
        public Status Status { set; get; }
    }
}
