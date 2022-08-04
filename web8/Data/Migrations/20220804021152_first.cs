using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web8.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Mobile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Mobile",
                columns: new[] { "Id", "BestSeller", "Brand", "Color", "Date", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, true, "Apple", "White", new DateTime(2022, 8, 4, 9, 11, 51, 493, DateTimeKind.Local).AddTicks(2256), "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", "Iphone X", 1000000f, 0 },
                    { 2, true, "Samsung", "White", new DateTime(2022, 8, 4, 9, 11, 51, 494, DateTimeKind.Local).AddTicks(9173), "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", "Samsung Galaxy S10", 8000000f, 0 },
                    { 3, true, "Apple", "White", new DateTime(2022, 8, 4, 9, 11, 51, 494, DateTimeKind.Local).AddTicks(9235), "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", "Iphone XS", 1000000f, 0 },
                    { 4, true, "Samsung", "White", new DateTime(2022, 8, 4, 9, 11, 51, 494, DateTimeKind.Local).AddTicks(9239), "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", "Samsung Galaxy S10 Plus", 8000000f, 0 },
                    { 5, true, "Apple", "White", new DateTime(2022, 8, 4, 9, 11, 51, 494, DateTimeKind.Local).AddTicks(9241), "https://cdn-amz.woka.io/images/I/61s0IaMcKtL.jpg", "Iphone XS Max", 1000000f, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mobile",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mobile",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mobile",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mobile",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mobile",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "Color",
                table: "Mobile",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
