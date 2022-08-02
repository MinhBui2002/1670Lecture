using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web7.Models
{
    public class Employee
    {
        
        public string Name { get; set; }
        [Range(18,50)]
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public float Salary { get; set; }
        public List<string> Strengths { get; set; }

        

    }
}
