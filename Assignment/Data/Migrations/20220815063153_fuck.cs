using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Data.Migrations
{
    public partial class fuck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthor_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    OrderQuantity = table.Column<int>(nullable: false),
                    OrderPrice = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "723bdd5c-7c67-471c-bb78-870526dabf8e", "Admin", "Admin" },
                    { "2", "eee7dd23-d00b-4710-b495-9abb92d3cd69", "Customer", "Customer" },
                    { "3", "0d476cc8-41b9-477b-ae5c-44c9a7f76271", "StoreOwner", "StoreOwner" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "90275bf0-9418-4e7b-b47f-32070ac8f009", "admin@gmail.com", false, false, null, null, "admin@gmail.com", "AQAAAAEAACcQAAAAEAT57f2drrRFvPWZhKKfdhTOD6DI0y/IENVNTCjNvjToXE6Qpi2j6FAgfNle1nujSw==", null, false, "8ef99b29-4ac1-4e4d-977d-40b70b8348b5", false, "admin@gmail.com" },
                    { "2", 0, "6e4b98f1-3655-4f3b-bb75-3c9f51db54cd", "customer@gmail.com", false, false, null, null, "customer@gmail.com", "AQAAAAEAACcQAAAAEKvsDgWVi+y8CiF+ojZzXTdtKpDNYzBrXVckgsp+LldBHe83zamKw5x4NBQOlm2NbA==", null, false, "bb5f4aec-c0b4-4931-943c-aae3e5d6e74f", false, "customer@gmail.com" },
                    { "3", 0, "fe95c721-04d5-4b30-8e10-a62b912fecc1", "storeowner@gmail.com", false, false, null, null, "storeowner@gmail.com", "AQAAAAEAACcQAAAAEFS9Cgbgx5samYZayW05uUWp5UPO4e0amfPVjv2Gn9f96QJ9fOjK7wueLqPIU66Qqg==", null, false, "cc7cdf23-db12-4264-bd91-baefb05bb07c", false, "storeowner@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "United Kingdom", "J.K. Rowling" },
                    { 2, "United States", "J.R.R. Tolkien" },
                    { 3, "United States", "Stephen King" },
                    { 4, "United States", "George R.R. Martin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Thriller" },
                    { 2, "Drama" },
                    { 3, "Horror" },
                    { 4, "Mystery" },
                    { 5, "Romance" },
                    { 6, "Sci-Fi" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Image", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, "https://bookbuy.vn/Res/Images/Product/harry-potter-tap-8-harry-porter-and-the-cursed-child-parts-one-two-special-rehearsal-edition-script-_52322_1.jpg", 120.0, 30, "Harry Potter" },
                    { 2, 1, "https://images-na.ssl-images-amazon.com/images/I/71Jk3baRdnL.jpg", 120.0, 30, "Godfather" },
                    { 5, 2, "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg", 120.0, 30, "The Shining" },
                    { 10, 2, "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg", 120.0, 30, "The Stand" },
                    { 3, 3, "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg", 120.0, 30, "The Shining" },
                    { 6, 3, "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg", 120.0, 30, "The Shining" },
                    { 4, 4, "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg", 120.0, 30, "The Stand" },
                    { 7, 4, "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg", 120.0, 30, "The Stand" },
                    { 8, 5, "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg", 120.0, 30, "The Shining" },
                    { 9, 6, "https://images-na.ssl-images-amazon.com/images/I/51-%2Bq%2BQ%2BcL._SX329_BO1,204,203,200_.jpg", 120.0, 30, "The Shining" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "BookId", "AuthorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 5, 1 },
                    { 3, 4 },
                    { 6, 3 },
                    { 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookId",
                table: "Order",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
