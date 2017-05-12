using System.Collections.Generic;
using System.Linq;

namespace WebApplicationBasic.Models
{
    public class BookRepository: IBookRepository
    {
        static List<Book> books = new List<Book>();

        static BookRepository() {
            books.Add(new Book{ Isbn = "000", Title = "Angular 4", Rating = 5 });
            books.Add(new Book{ Isbn = "111", Title = ".NET Core", Description = "Alte Zöpfe weg", Rating = 5 });
        }

        public IEnumerable<Book> FindAll() {
            return books.OrderBy(f => f.Isbn);
        }

        public Book FindByIsbn(string isbn) {
            return books.FirstOrDefault(f => f.Isbn == isbn);
        }
    }
}