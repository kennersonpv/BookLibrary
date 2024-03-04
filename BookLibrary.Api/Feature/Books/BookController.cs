using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Feature.Books
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookUseCase _useCase;
        public BookController(IBookUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks(
                    string author = "",
                    string isnb = "")
        {

            var response = await _useCase.Handle(new BookRequest(author, isnb));
            if (response.IsSuccess)
            {
                return Ok(response.Value);
            }

            return Problem(response.Error.Description);
        }
    }
}
