using BookLibrary.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using WebApi.Abstractions;

namespace BookLibrary.Repository.Repositories.Books
{
    public class BooksRepository : IBooksRepository
    {
        private readonly DbContextOptions<BookLibraryDbContext> _dbContext;

        public BooksRepository(DbContextOptions<BookLibraryDbContext> dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<IEnumerable<BookEntity>>> GetBooksAsync(string author = "", string isnb = "")
        {
            try
            {
                using (var context = new BookLibraryDbContext(_dbContext))
                {
                    var result = await context.Books.ToListAsync();

                    if (!string.IsNullOrEmpty(author))
                    {
                        result = result.Where(x => x.FirstName.Contains(author) || x.LastName.Contains(author)).ToList();
                    }

                    if (!string.IsNullOrEmpty(isnb))
                    {
                        result = result.Where(x => x.ISBN == isnb).ToList();
                    }

                    return Result<IEnumerable<BookEntity>>.Success(result);
                }
            }
            catch (Exception)
            {

                return Result<IEnumerable<BookEntity>>.Failure(new Error("Get", "Error to get books"));
            }
        }
    }
}
