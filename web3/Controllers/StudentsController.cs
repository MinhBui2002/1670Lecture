using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web3.Models;

namespace web3.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            Student s1 = new Student(1, "John", 20, "123-456-7890");
            Student s2 = new Student(2, "Jane", 21, "123-456-7891");
            Student s3 = new Student(3, "Jack", 22, "123-456-7892");
            Student s4 = new Student(4, "Jill", 23, "123-456-7893");
            

            //create a list of students 
            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);


            return View(students);
        }
    }
}
