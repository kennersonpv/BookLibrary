using BookLibrary.Repository.Entities;
using WebApi.Abstractions;

namespace BookLibrary.Repository.Repositories.Books
{
    public interface IBooksRepository
    {
        Task<Result<IEnumerable<BookEntity>>> GetBooksAsync(string author = "", string isnb = "");
    }
}
