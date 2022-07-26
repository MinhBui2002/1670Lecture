using System.ComponentModel.DataAnnotations;

namespace web4.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(20, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string Name { get; set; }
        [MinLength(10)]
        [MaxLength(50)]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Range(1, 100)]
        public string Quantity { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
