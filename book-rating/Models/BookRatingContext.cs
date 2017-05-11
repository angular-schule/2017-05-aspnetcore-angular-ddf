using Microsoft.EntityFrameworkCore;

namespace WebApplicationBasic.Models
{
    public class BookRatingContext : DbContext
    {
        public BookRatingContext(DbContextOptions<BookRatingContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasKey(t => t.Isbn);
        }

        public DbSet<Book> Books { get; set; }
    }
}