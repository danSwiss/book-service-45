namespace BookService.Migrations
{
    using BookService.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Authors.AddOrUpdate(x => x.Id,
                new Author() { Id = 1, Name = "Seth Godin" },
                new Author() { Id = 2, Name = "William I Robinson" },
                new Author() { Id = 3, Name = "Don Peppers and Martha Rogers, Ph.D." });

            context.Books.AddOrUpdate(x => x.Id,
                new Book() { Id = 1, Title = "Linchpin", Year = 2010, AuthorId = 1, Price = 25.99M, Genre = "Self Help" },
                new Book() { Id = 2, Title = "Purple Cow", Year = 2002, AuthorId = 1, Price = 9.99M, Genre = "Self Help" },
                new Book() { Id = 3, Title = "A Theory of Global Capitalism", Year = 2004, AuthorId = 2, Price = 19.99M, Genre = "Economics" },
                new Book() { Id = 4, Title = "The One To One Future", Year = 1900, AuthorId = 3, Price = 14.99M, Genre = "Ethics" },
                new Book() { Id = 5, Title = "Extreme Trust, Honesty as a Competitive Advantage", Year = 2012, AuthorId = 3, Price = 10.99M, Genre = "Ethics" });
        }
    }
}
