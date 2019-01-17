using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //This is wrong creates a Circular Reference
        //public ICollection<Book> Books {get; set;}
    }
}