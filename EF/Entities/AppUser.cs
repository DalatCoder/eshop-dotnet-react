using Microsoft.AspNetCore.Identity;

namespace eShopSolutionReact.EF.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public List<Cart>? Carts { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
