using WebApi.Abstractions;
using WebApi.Repository.Entities;
using WebApi.Repository.Repositories.Users;

namespace WebApi.Feature.User.Insert
{
    public class InsertUserUseCase : IInsertUserUseCase
    {
        private readonly IUsersRepository _usersRepository;

        public InsertUserUseCase(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<Result<InsertUserResponse>> Handle(InsertUserRequest request, CancellationToken cancellationToken)
        {
            var user = new UserEntity()
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password
            };

            var response = await _usersRepository.InsertUserAsync(user, cancellationToken);

            if(response.IsSuccess)
            {
                return Result<InsertUserResponse>.Success(new InsertUserResponse(response.Value));
            }

            return Result<InsertUserResponse>.Failure(new Error("User", "Error to create User"));
        }
    }
}
