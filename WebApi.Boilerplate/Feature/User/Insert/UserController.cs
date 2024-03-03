using Microsoft.AspNetCore.Mvc;

namespace WebApi.Feature.User.Insert
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IInsertUserUseCase _useCase;
        public UserController(IInsertUserUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost("Create")]
        public async Task<InsertUserResponse> CreateUser(
            [FromBody] InsertUserRequest request,
            CancellationToken cancellationToken
            )
        {
            var response = await _useCase.Handle(request, cancellationToken);
            return response.Value;
        }
    }
}
