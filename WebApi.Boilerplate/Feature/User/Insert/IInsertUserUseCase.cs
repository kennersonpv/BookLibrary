using WebApi.Abstractions;

namespace WebApi.Feature.User.Insert
{
    public interface IInsertUserUseCase
    {
        Task<Result<InsertUserResponse>> Handle(InsertUserRequest request, CancellationToken cancellationToken);
    }

    public record InsertUserRequest(string Name, string Email, string Password);
    public record InsertUserResponse(int userId);
}
