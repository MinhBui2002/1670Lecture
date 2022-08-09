using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web10.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string Image { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}