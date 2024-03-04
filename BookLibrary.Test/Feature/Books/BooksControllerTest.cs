using BookLibrary.Feature.Books;
using BookLibrary.Repository.Entities;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebApi.Abstractions;

namespace BookLibrary.Test.Feature.Books
{
    public class BooksControllerTest
    {
        private readonly Mock<IBookUseCase> _useCase;
        private readonly BookController _controller;

        public BooksControllerTest()
        {
            _useCase = new Mock<IBookUseCase>();
            _controller = new BookController(_useCase.Object);
        }

        [Fact]
        public async void GetBooks_ShouldBe_200()
        {
            //Arrange
            var books = new List<BookEntity>();

            var result = Result<BookResponse>.Success(new BookResponse(books));

            _useCase
               .Setup(x => x.Handle(It.IsAny<BookRequest>()))
               .ReturnsAsync(result);

            //Act
            var response = await _controller.GetBooks(It.IsAny<string>(), It.IsAny<string>());
            var objectResult = response as ObjectResult;

            //Assert
            Assert.Equal(objectResult.StatusCode, 200);
        }

        [Fact]
        public async void GetBooks_ShouldBe_500()
        {
            //Arrange
            var result = Result<BookResponse>.Failure(new Error("Error"));

            _useCase
               .Setup(x => x.Handle(It.IsAny<BookRequest>()))
               .ReturnsAsync(result);

            //Act
            var response = await _controller.GetBooks(It.IsAny<string>(), It.IsAny<string>());
            var objectResult = response as ObjectResult;

            //Assert
            Assert.Equal(objectResult.StatusCode, 500);
        }
    }
}
