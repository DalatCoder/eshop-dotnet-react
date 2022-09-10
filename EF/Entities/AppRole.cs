using Microsoft.AspNetCore.Identity;

namespace eShopSolutionReact.EF.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
