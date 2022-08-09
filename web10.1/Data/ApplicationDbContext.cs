using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web10._1.Models;

namespace web10._1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedDepartment(modelBuilder);
            SeedEmployee(modelBuilder);
        }

        private void SeedEmployee(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    DepartmentId = 1,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'M',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                },
                new Employee
                {
                    Id = 2,
                    Name = "John",
                    DepartmentId = 2,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'F',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                },
                new Employee
                {
                    Id = 3,
                    Name = "John",
                    DepartmentId = 5,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'M',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                },
                new Employee
                {
                    Id = 4,
                    Name = "John",
                    DepartmentId = 5,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'F',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                },
                new Employee
                {
                    Id = 5,
                    Name = "John",
                    DepartmentId = 3,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'M',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                },
                new Employee
                {
                    Id = 6,
                    Name = "John",
                    DepartmentId = 2,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'F',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                },
                new Employee
                {
                    Id = 7,
                    Name = "John",
                    DepartmentId = 1,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'F',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                },
                new Employee
                {
                    Id = 8,
                    Name = "John",
                    DepartmentId = 2,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'F',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                },
                new Employee
                {
                    Id = 9,
                    Name = "John",
                    DepartmentId = 3,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'F',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                },
                new Employee
                {
                    Id = 10,
                    Name = "John",
                    DepartmentId = 4,
                    Dob = DateTime.Parse("1989-09-01"),
                    Mobile = "0987654321",
                    Address = "123 Nguyen Van Linh",
                    Gender = 'F',
                    Salary = 424,
                    Image = "https://media.istockphoto.com/photos/indoor-photo-of-handsome-european-guy-pictured-isolated-on-grey-to-picture-id1034357476?k=20&m=1034357476&s=612x612&w=0&h=OpiBGaVDU02LI1WVpb02Wza6AAdTGopRpf0Kx6q8V-Q="

                }


                );
        }
        private void SeedDepartment(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1,
                    Name = "IT",
                    Image = "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg="
                },
                new Department
                {
                    Id = 2,
                    Name = "HR",
                    Image = "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg="
                },
                new Department
                {
                    Id = 3,
                    Name = "Marketing",
                    Image = "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg="
                },
                new Department
                {
                    Id = 4,
                    Name = "Sales",
                    Image = "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg="
                },
                new Department
                {
                    Id = 5,
                    Name = "Accounting",
                    Image = "https://media.istockphoto.com/photos/department-of-state-23rd-street-entrance-picture-id1144041262?k=20&m=1144041262&s=612x612&w=0&h=fFF1aYVF-5f38_jCEcIKgkZEEmEAcI3RLOZ-PA8kryg="
                });
            ;
        }
    }
}
