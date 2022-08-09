using System;
using System.ComponentModel.DataAnnotations;

namespace web10.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "Max length for name is 30", MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }


        [MinLength(3, ErrorMessage = "Min length for address is 3")]
        [MaxLength(30, ErrorMessage = "Max length for address is 30")]
        public string Address { get; set; }


        [Required]
        public char Gender { get; set; }

        [Range(100, 2000)]
        public float Salary { get; set; }


        [MaxLength(10)]
        [MinLength(10)]
        [Phone]
        public string Mobile { get; set; }

        [Url]
        public string Image { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
