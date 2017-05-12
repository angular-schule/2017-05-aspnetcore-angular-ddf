using System.Collections.Generic;

namespace WebApplicationBasic.Models
{
    public interface IBookRepository
    {
         IEnumerable<Book> FindAll();
         Book FindByIsbn(string isbn);
    }
}