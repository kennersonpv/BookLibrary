using WebApi.Abstractions;

namespace WebApi.Repository.Repositories.Users
{
    public interface IUsersRepository
    {
        Task<Result<int>> InsertUserAsync(Entities.UserEntity user, CancellationToken cancellationToken);
        Task<Result<int>> UserExistsByEmailAsync(string email, CancellationToken cancellationToken);
        Task<Result<bool>> UserExistsByEmailPasswordAsync(string email, string password, CancellationToken cancellationToken);
    }
}
