using System.Collections.Generic;

namespace web11.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        // One to Many
        
        public ICollection<Branch> Branch { get; set; }
    }
}
