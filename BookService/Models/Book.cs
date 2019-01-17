using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        //Foreign Key
        public int AuthorId { get; set; }

        //Use for Egar Loading
        //Navigarion Property
        public Author Author { get; set; }

        //(Other Properties)
        // Lazy loading
        // Allows code like this
        //var books = db.Books.ToList();  // Does not load authors
        //var author = books[0].Author;   // Loads the author for books[0]
        // Virtual navigation property

        //public virtual Author Author { get; set; }

        //Lazy loading requires multiple database trips, 
        //because EF sends a query each time it retrieves a related entity.
        //Generally, you want lazy loading disabled for objects that you serialize.
        //The serializer has to read all of the properties on the model, 
        //which triggers loading the related entities. 
        //For example, here are the SQL queries when EF serializes the list of books with lazy loading enabled. 
        //You can see that EF makes three separate queries for the three authors.
    }
}