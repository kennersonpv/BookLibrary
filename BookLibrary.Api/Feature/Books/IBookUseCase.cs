using BookLibrary.Repository.Entities;
using WebApi.Abstractions;

namespace BookLibrary.Feature.Books
{
    public interface IBookUseCase
    {
        Task<Result<BookResponse>> Handle(BookRequest request);
    }

    public record BookRequest(string author = "", string isnb = "");
    public record BookResponse(IEnumerable<BookEntity> books);
}
