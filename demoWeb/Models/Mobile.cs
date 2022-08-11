using System.ComponentModel.DataAnnotations;

namespace demoWeb.Models
{
    public enum Color
    {
        Black,
        White,
        Pink,
        Purple,
        Brown
    }
    public class Mobile
    {
        public int Id { get; set; }
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Range(1,100)]
        public int Quantity { get; set; }
        public double Price { get; set; }
        [Url]
        public string Image { get; set; }
        public Color Color { get; set; }
        
        public Brand Brand { get; set; }
        [Display(Name = "Brand name")]
        public int BrandId { get; set; }
        
    }
}
