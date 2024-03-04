using BookLibrary.Repository;
using BookLibrary.Repository.Repositories.Books;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace BookLibrary.Test.Repository
{
    public class BooksRepositoryTest
    {
        private readonly Mock<DbContextOptions<BookLibraryDbContext>> _dbContextOptionsMock;
        private readonly Mock<BookLibraryDbContext> _dbContextMock;
        private readonly IBooksRepository _repository;

        public BooksRepositoryTest()
        {
            _dbContextOptionsMock = new Mock<DbContextOptions<BookLibraryDbContext>>();
            _dbContextMock = new Mock<BookLibraryDbContext>(_dbContextOptionsMock.Object);
            _repository = new BooksRepository( _dbContextOptionsMock.Object );
        }

        [Fact]
        public async Task GetBooks_Success()
        {
            // Arrange
            var author = "author";
            var isnb = "isnb";

            // Act
            var result = await _repository.GetBooksAsync(author, isnb);

            // Assert
            Assert.True(result.IsSuccess);
            _dbContextMock.Verify(db => db.Books, Times.Once);
        }
    }
}
