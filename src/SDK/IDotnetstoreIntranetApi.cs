using Refit;
using SDK.Dto.Users.Requests;
using SDK.Dto.Users.Responses;

namespace SDK;

public interface IDotnetstoreIntranetApi
{
    [Post(ApiEndpoints.Users.Create)]
    Task<UserResponse> CreateUserAsync(CreateUserRequest request);
}