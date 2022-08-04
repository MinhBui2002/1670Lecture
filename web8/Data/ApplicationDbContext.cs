using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web8.Models;

namespace web8.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<web8.Models.Mobile> Mobile { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //add data to Mobile table
            modelBuilder.Entity<Mobile>().HasData(
                new Mobile
                {
                    Id = 1,
                    Name = "Iphone X",
                    Price = 1000000,
                    Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg",
                    BestSeller = true,
                    Brand = "Apple",
                    Color = "White",
                    Date = DateTime.Now
                },
                new Mobile
                {
                    Id = 2,
                    Name = "Samsung Galaxy S10",
                    Price = 8000000,
                    Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg",
                    BestSeller = true,
                    Brand = "Samsung",
                    Color = "White",
                    Date = DateTime.Now
                },
                new Mobile
                {
                    Id = 3,
                    Name = "Iphone XS",
                    Price = 1000000,
                    Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg",
                    BestSeller = true,
                    Brand = "Apple",
                    Color = "White",
                    Date = DateTime.Now
                },
                new Mobile
                {
                    Id = 4,
                    Name = "Samsung Galaxy S10 Plus",
                    Price = 8000000,
                    Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg",
                    BestSeller = true,
                    Brand = "Samsung",
                    Color = "White",
                    Date = DateTime.Now
                },
                new Mobile
                {
                    Id = 5,
                    Name = "Iphone XS Max",
                    Price = 1000000,
                    Image = "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg",
                    BestSeller = true,
                    Brand = "Apple",
                    Color = "White",
                    Date = DateTime.Now
                }



                );
        }

    }
}
