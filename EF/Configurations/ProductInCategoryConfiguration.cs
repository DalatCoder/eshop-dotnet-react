using eShopSolutionReact.EF.Entities;
using eShopSolutionReact.EF.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolutionReact.EF.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");

            builder.HasKey(x =>
            new
            {
                x.CategoryId,
                x.ProductId
            });

            // builder
            //     .HasOne(x => x.Product)
            //     .WithMany(x => x.ProductInCategories)
            //     .HasForeignKey(x => x.ProductId);

            // builder
            //     .HasOne(x => x.Category)
            //     .WithMany(x => x.ProductInCategories)
            //     .HasForeignKey(x => x.CategoryId);
        }
    }
}
