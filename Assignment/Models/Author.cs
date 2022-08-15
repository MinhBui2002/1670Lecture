using System.Collections.Generic;

namespace Assignment.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public ICollection<BookAuthor> BookAuthor { get; set; }

    }
}
