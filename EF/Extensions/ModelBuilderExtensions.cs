using eShopSolutionReact.EF.Entities;
using eShopSolutionReact.EF.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolutionReact.EF.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Title = "Áo sơ mi"
                },
                new Category()
                {
                    Id = 2,
                    Title = "Áo thun"
                },
                new Category()
                {
                    Id = 3,
                    Title = "Quần jean"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo sơ mi dài tay",
                    Description = "Áo sơ mi dài tay",
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 100,
                    ViewCount = 0,
                },
                new Product()
                {
                    Id = 2,
                    CategoryId = 2,
                    Name = "Áo thun cổ tròn",
                    Description = "Áo thun cổ tròn",
                    DateCreated = DateTime.Now,
                    OriginalPrice = 50000,
                    Price = 80000,
                    Stock = 100,
                    ViewCount = 0,
                }
            );

            // For Identity Tables
            var roleId = new Guid("E5D9C703-E3D4-49F6-8835-EDE2A7A035FC");
            var adminId = new Guid("F9246E52-297E-4D04-964F-CC930E93947A");

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "hieuntctk42@gmail.com",
                NormalizedEmail = "hieuntctk42@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abc@123*"),
                SecurityStamp = string.Empty,
                FirstName = "Hieu",
                LastName = "Nguyen Trong",
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
