using Refit;
using SDK.Dto.Organization.Users.Requests;
using SDK.Dto.Organization.Users.Responses;

namespace SDK;

public interface IOrganizationDotnetstoreIntranetApi
{
    [Post(ApiEndpoints.Organization.Users.Create)]
    Task<UserResponse> CreateUserAsync(CreateUserRequest request);
}