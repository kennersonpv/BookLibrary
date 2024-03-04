using BookLibrary.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Repository
{
    public class BookLibraryDbContext : DbContext
    {
        public DbSet<BookEntity> Books { get; set; }
        public BookLibraryDbContext(DbContextOptions<BookLibraryDbContext> options) : base(options)
        {
        }
    }
}
