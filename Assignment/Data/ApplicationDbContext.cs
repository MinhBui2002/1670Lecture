using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<Author> Authors { get; set; }
        



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedAuthor(builder);
            SeedCategory(builder);
            SeedBook(builder);
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);

        }

        private void SeedAuthor(ModelBuilder builder)
        {
            builder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    Name = "J.K. Rowling",
                    Country = "United Kingdom"
                },
                new Author
                {
                    Id = 2,
                    Name = "J.R.R. Tolkien",
                    Country = "United States"
                },
                new Author
                {
                    Id = 3,
                    Name = "Stephen King",
                    Country = "United States"
                },
                new Author
                {
                    Id = 4,
                    Name = "George R.R. Martin",
                    Country = "United States"
                }
                );
        }

       

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "2"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "3"
                }
            );
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "Admin"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Customer",
                    NormalizedName = "Customer"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "StoreOwner",
                    NormalizedName = "StoreOwner"
                }
            );
        }

        private void SeedUser(ModelBuilder builder)
        {
            //tạo tài khoản test cho admin & customer
            var admin = new IdentityUser
            {
                Id = "1",
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com"
            };
            var customer = new IdentityUser
            {
                Id = "2",
                Email = "customer@gmail.com",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com"
            };
            var storeOwner = new IdentityUser
            {
                Id = "3",
                Email = "storeowner@gmail.com",
                UserName = "storeowner@gmail.com",
                NormalizedUserName = "storeowner@gmail.com"
            };

            //khai báo thư viện để mã hóa mật khẩu cho user
            var hasher = new PasswordHasher<IdentityUser>();

            //set mật khẩu đã mã hóa cho từng user
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");
            storeOwner.PasswordHash = hasher.HashPassword(storeOwner, "123456");

            //add 2 tài khoản test vào bảng User
            builder.Entity<IdentityUser>().HasData(admin, customer, storeOwner);
        }


        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Harry Potter",
                    Price = 120,
                    Image = "https://bookbuy.vn/Res/Images/Product/harry-potter-tap-8-harry-porter-and-the-cursed-child-parts-one-two-special-rehearsal-edition-script-_52322_1.jpg",
                    Quantity = 30,
                    CategoryId = 1,
                    AuthorId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Godfather",
                    Price = 120,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/71Jk3baRdnL.jpg",
                    Quantity = 30,
                    CategoryId = 1,
                    AuthorId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "The Shining",
                    Price = 120,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg",
                    Quantity = 30,
                    CategoryId = 3,
                    AuthorId = 2
                },
                new Book
                {
                    Id = 4,
                    Title = "The Stand",
                    Price = 120,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg",
                    Quantity = 30,
                    CategoryId = 4,
                    AuthorId = 3

                },
                new Book
                {
                    Id = 5,
                    Title = "The Shining",
                    Price = 120,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg",
                    Quantity = 30,
                    CategoryId = 2,
                    AuthorId = 4
                },
                new Book
                {
                    Id = 6,
                    Title = "The Shining",
                    Price = 120,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg",
                    Quantity = 30,
                    CategoryId = 3,
                    AuthorId = 1
                },
                new Book
                {
                    Id = 7,
                    Title = "The Stand",
                    Price = 120,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg",
                    Quantity = 30,
                    CategoryId = 4,
                    AuthorId = 2
                },
                new Book
                {
                    Id = 8,
                    Title = "The Shining",
                    Price = 120,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg",
                    Quantity = 30,
                    CategoryId = 5,
                    AuthorId = 3
                },
                new Book
                {
                    Id = 9,
                    Title = "The Shining",
                    Price = 120,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg",
                    Quantity = 30,
                    CategoryId = 6,
                    AuthorId = 4
                },
                new Book
                {
                    Id = 10,
                    Title = "The Stand",
                    Price = 120,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg",
                    Quantity = 30,
                    CategoryId = 2,
                    AuthorId = 1
                }
                );
        }

        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Thriller"
                },
                new Category
                {
                    Id = 2,
                    Name = "Drama"
                },
                new Category
                {
                    Id = 3,
                    Name = "Horror"
                },
                new Category
                {
                    Id = 4,
                    Name = "Mystery"
                },
                new Category
                {
                    Id = 5,
                    Name = "Romance"
                },
                new Category
                {
                    Id = 6,
                    Name = "Sci-Fi"
                }
                );
        }
    }
}
