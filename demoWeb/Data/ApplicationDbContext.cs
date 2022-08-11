using demoWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedCountry(builder);
            SeedBrand(builder);
            SeedMobile(builder);
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);
        }
        private void SeedCountry(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Korea" },
                new Country { Id = 2, Name = "USA" },
                new Country { Id = 3, Name = "China" }
                );
        }
        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "1", RoleId = "A" },
                new IdentityUserRole<string> { UserId = "2", RoleId = "B" }
                );
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "A", Name = "Admin" },
                new IdentityRole { Id = "B", Name = "User" }
                );
        }

        private void SeedUser(ModelBuilder builder)
        {

            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                Email = "admin@gmail.com"
            };
            var customer = new IdentityUser
            {
                Id = "2",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com",
                Email = "customer@gmail.com"
            };
            var hasher = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");
            builder.Entity<IdentityUser>().HasData(admin, customer);
        }

        private void SeedMobile(ModelBuilder builder)
        {
            builder.Entity<Mobile>().HasData(
                new Mobile { Id = 1, Quantity = 50, Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", Color = Color.Black, BrandId = 1, Name = "Samsung Galaxy S10", Price = 899.99 },
                new Mobile { Id = 2, Quantity = 50, Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", Color = Color.Brown, BrandId = 2, Name = "Samsung Galaxy S10+", Price = 999.99 },
                new Mobile { Id = 3, Quantity = 50, Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", Color = Color.Pink, BrandId = 3, Name = "Samsung Galaxy S10e", Price = 799.99 },
                new Mobile { Id = 4, Quantity = 50, Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", Color = Color.Purple, BrandId = 4, Name = "Samsung Galaxy S10e+", Price = 899.99 },
                new Mobile { Id = 5, Quantity = 50, Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", Color = Color.White, BrandId = 5, Name = "Samsung Galaxy S10+", Price = 999.99 },
                new Mobile { Id = 6, Quantity = 50, Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", Color = Color.Black, BrandId = 6, Name = "Samsung Galaxy S10", Price = 899.99 }


                );


        }
        private void SeedBrand(ModelBuilder builder)
        {
            builder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Samsung" },
                new Brand { Id = 2, Name = "Apple" },
                new Brand { Id = 3, Name = "Huawei" },
                new Brand { Id = 4, Name = "Xiaomi" },
                new Brand { Id = 5, Name = "Oppo" },
                new Brand { Id = 6, Name = "Vivo" }
                );

        }
    }
}
