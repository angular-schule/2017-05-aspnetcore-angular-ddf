using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplicationBasic.Models;

namespace WebApplicationBasic.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        IBookRepository repository;

        public BookController(IBookRepository repository)
        {
            this.repository = repository;
        }

        // GET /api/Book
        [HttpGet]
        public IEnumerable<Book> GetAll() {
            return this.repository.FindAll();
        }

        // GET /api/Book/000
        [HttpGet("{isbn}")]
        public Book GetByIsbn(string isbn) {
            return this.repository.FindByIsbn(isbn);
        }
    }
}
