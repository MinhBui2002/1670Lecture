using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web11.Models;

namespace web11.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<Capital> Capital { get; set; }
        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedBank(modelBuilder);
            SeedBranch(modelBuilder);
            SeedCourse(modelBuilder);
            SeedStudent(modelBuilder);
            SeedStudentCourse(modelBuilder);
            SeedCapital(modelBuilder);
            SeedCountry(modelBuilder);

        }

        private void SeedCountry(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "USA" ,Population = 32354324},
                new Country { Id = 2, Name = "Canada" ,Population = 32354324},
                new Country { Id = 3, Name = "Mexico" ,Population = 32354324},
                new Country { Id = 4, Name = "Brazil" ,Population = 32354324},
                new Country { Id = 5, Name = "Argentina" ,Population = 32354324},
                new Country { Id = 6, Name = "Chile" ,Population = 32354324});


        }

        private void SeedCapital(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Capital>().HasData(
                new Capital { Id = 1, Name = "Washington", CountryId = 1, Area = 324523 },
                new Capital { Id = 2, Name = "Ottawa", CountryId = 2, Area = 324523 },
                new Capital { Id = 3, Name = "Mexico City", CountryId = 3, Area = 324523 },
                new Capital { Id = 4, Name = "Brasilia", CountryId = 4, Area = 324523 },
                new Capital { Id = 5, Name = "Buenos Aires", CountryId = 5, Area = 324523 },
                new Capital { Id = 6, Name = "Santiago", CountryId = 6, Area = 324523 });
        }

        private void SeedStudentCourse(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId,sc.CourseId});
            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseId = 1 },
                new StudentCourse { StudentId = 2, CourseId = 3 },
                new StudentCourse { StudentId = 3, CourseId = 3 },
                new StudentCourse { StudentId = 1, CourseId = 5 },
                new StudentCourse { StudentId = 4, CourseId = 2 });
               
        }


        private void SeedStudent(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "John Doe" , Email = "@gmail.com"},
                new Student { Id = 2, Name = "Jane Doe" , Email = "@gmail.com"},
                new Student { Id = 3, Name = "John Smith" , Email = "@gmail.com"},
                new Student { Id = 4, Name = "Jane Smith" , Email = "@gmail.com"},
                new Student { Id = 5, Name = "John Doe" , Email = "@gmail.com"},
                new Student { Id = 6, Name = "Jane Doe" , Email = "@gmail.com"},
                new Student { Id = 7, Name = "John Smith" , Email = "@gmail.com"},
                new Student { Id = 8, Name = "Jane Smith" , Email = "@gmail.com"},
                new Student { Id = 9, Name = "John Doe" , Email = "@gmail.com"},
                new Student { Id = 10, Name = "Jane Doe" , Email = "@gmail.com"},
                new Student { Id = 11, Name = "John Smith" , Email = "@gmail.com"},
                new Student { Id = 12, Name = "Jane Smith", Email = "@gmail.com" }
                );
        }

        private void SeedCourse(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1,Description = "No", Name = "C#" },
                new Course { Id = 2,Description = "No", Name = "Java" },
                new Course { Id = 3,Description = "No", Name = "Python" },
                new Course { Id = 4,Description = "No", Name = "C++" },
                new Course { Id = 5,Description = "No", Name = "JavaScript" },
                new Course { Id = 6,Description = "No", Name = "PHP" },
                new Course { Id = 7,Description = "No", Name = "C#" },
                new Course { Id = 8,Description = "No", Name = "Java" },
                new Course { Id = 9,Description = "No", Name = "Python" },
                new Course { Id = 10,Description = "No", Name = "C++" },
                new Course { Id = 11,Description = "No", Name = "JavaScript" },
                new Course { Id = 12,Description = "No", Name = "PHP" }
                );
        }

        private void SeedBranch(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Branch>().HasData(
                new Branch { Id = 1, BankId = 1,  Address = "New york", Name = "Branch 1" },
                new Branch { Id = 2, BankId = 2 ,Address = "New york", Name = "Branch 2" },
                new Branch { Id = 3, BankId = 3 ,Address = "New york", Name = "Branch 3" },
                new Branch { Id = 4, BankId = 4 ,Address = "New york", Name = "Branch 4" },
                new Branch { Id = 5, BankId = 5 ,Address = "New york", Name = "Branch 5" }
                
                );
        }

        public void SeedBank(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>().HasData(
                new Bank { Id = 1,Type = "1", Name = "Bank of America" },
                new Bank { Id = 2,Type = "1", Name = "Bank of Canada" },
                new Bank { Id = 3,Type = "1", Name = "Bank of Nova Scotia" },
                new Bank { Id = 4,Type = "1", Name = "Bank of New York" },
                new Bank { Id = 5,Type = "1", Name = "Bank of Nova Scotia" });

        }
    }
}
