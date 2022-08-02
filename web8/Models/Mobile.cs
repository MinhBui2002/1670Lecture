using System;
using System.ComponentModel.DataAnnotations;

namespace web8.Models
{
    public enum Color
    {
        Black,
        White,
        Red,
        Blue,
    }
    public class Mobile
    {


        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        
        [Range(1,50)]
        public int Quantity { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        public bool BestSeller { get; set; }
    }
}
