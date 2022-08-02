using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web8.Data.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mobile",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "BestSeller",
                table: "Mobile",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Mobile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Mobile",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BestSeller",
                table: "Mobile");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Mobile");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Mobile");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mobile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
