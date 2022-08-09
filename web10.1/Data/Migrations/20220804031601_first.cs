using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web10._1.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg=", "IT" },
                    { 2, "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg=", "HR" },
                    { 3, "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg=", "Marketing" },
                    { 4, "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg=", "Sales" },
                    { 5, "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg=", "Accounting" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "Dob", "Gender", "Image", "Mobile", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "123 Nguyen Van Linh", 1, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f },
                    { 7, "123 Nguyen Van Linh", 1, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f },
                    { 2, "123 Nguyen Van Linh", 2, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f },
                    { 6, "123 Nguyen Van Linh", 2, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f },
                    { 8, "123 Nguyen Van Linh", 2, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f },
                    { 5, "123 Nguyen Van Linh", 3, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f },
                    { 9, "123 Nguyen Van Linh", 3, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f },
                    { 10, "123 Nguyen Van Linh", 4, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f },
                    { 3, "123 Nguyen Van Linh", 5, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f },
                    { 4, "123 Nguyen Van Linh", 5, new DateTime(1989, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q=", "0987654321", "John", 424f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
