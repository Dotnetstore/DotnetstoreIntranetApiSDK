using FluentAssertions;
using NSubstitute;
using SDK.Dto.Organization.Users.Requests;
using SDK.Dto.Organization.Users.Responses;

namespace SDK.Test;

public class DotnetstoreIntranetApiTests
{
    [Fact]
    public async Task CreateUserAsync_ShouldReturnExpectedUserResponse()
    {
        // Arrange
        var mockApi = Substitute.For<IOrganizationDotnetstoreIntranetApi>();
        var request = new CreateUserRequest(
            "Doe",
            "John",
            "A",
            "Johnny",
            "123-45-6789",
            new DateTime(1990, 1, 1),
            true,
            false,
            "johndoe",
            "password123",
            "password123"
        );
        var expectedResponse = new UserResponse(
            Guid.NewGuid(),
            "Doe",
            "John",
            "A",
            "Johnny",
            "123-45-6789",
            new DateTime(1990, 1, 1),
            true,
            false,
            false,
            false
        );

        mockApi.CreateUserAsync(request).Returns(expectedResponse);

        // Act
        var actualResponse = await mockApi.CreateUserAsync(request);

        // Assert
        actualResponse.Should().Be(expectedResponse);
    }
}