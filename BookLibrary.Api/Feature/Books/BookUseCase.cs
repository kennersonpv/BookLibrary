using BookLibrary.Repository.Repositories.Books;
using WebApi.Abstractions;

namespace BookLibrary.Feature.Books
{
    public class BookUseCase : IBookUseCase
    {
        private readonly IBooksRepository _repository;

        public BookUseCase(IBooksRepository repository)
        {
            _repository = repository;            
        }

        public async Task<Result<BookResponse>> Handle(BookRequest request)
        {
            var response = await _repository.GetBooksAsync(request.author, request.isnb);

            if (response.IsSuccess)
            {
                return Result<BookResponse>.Success(new BookResponse(response.Value));
            }

            return Result<BookResponse>.Failure(response.Error);
        }
    }
}
