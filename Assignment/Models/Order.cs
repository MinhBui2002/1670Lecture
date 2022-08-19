using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
namespace Assignment.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int BookId { get; set; }  

        //Order - Mobile: Many To One
        public Book Book { get; set; }  
        public string UserEmail { get; set; }

        [Required]
        public int OrderQuantity { get; set; }

        [Required]
        public double OrderPrice { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        public string Status { get; set; }
    }
}
