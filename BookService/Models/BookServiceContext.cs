using System.Data.Entity;

namespace BookService.Models
{
    public class BookServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public BookServiceContext() : base("name=BookServiceContext")
        {
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            //turned off Lazy loading for all entities
            //Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
