using WebApi.Abstractions;
using WebApi.Repository.Entities;

namespace WebApi.Repository.Repositories.Users
{
    public class UsersRepository : IUsersRepository
    {
        public async Task<Result<int>> InsertUserAsync(UserEntity user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<int>> UserExistsByEmailAsync(string email, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<bool>> UserExistsByEmailPasswordAsync(string email, string password, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
