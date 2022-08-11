using System.Collections.Generic;

namespace demoWeb.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Brand> Brands { get; set; }
    }
}
