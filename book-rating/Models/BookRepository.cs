using System.Collections.Generic;
using System.Linq;

namespace WebApplicationBasic.Models
{
    public class BookRepository : IBookRepository
    {
        private BookRatingContext context;

        public BookRepository(BookRatingContext context)
        {

            this.context = context;

            context.Database.EnsureCreated();

            if (!context.Books.Any())
            {
                context.Books.Add(new Book { Isbn = "000", Title = "Angular 4", Description = "TypeScript im Web", Rating = 5 });
                context.Books.Add(new Book { Isbn = "111", Title = ".NET Core", Rating = 3 });
                context.SaveChanges();
            }
        }
        public IEnumerable<Book> FindAll()
        {
            return this.context.Books.OrderBy(f => f.Isbn);
        }

        public Book FindByIsbn(string isbn)
        {
            return this.context.Books.FirstOrDefault(f => f.Isbn == isbn);
        }
    }
}