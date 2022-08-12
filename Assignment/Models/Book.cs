using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        [Url]
        public string Image { get; set; }
        public decimal Price { get; set; }
        [Range(1, 100)]
        public int Quantity { get; set; }
        [Display(Name = "Brand name")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
