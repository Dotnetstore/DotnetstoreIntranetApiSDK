using FluentAssertions;

namespace SDK.Test;

public class ApiEndpointsTests
{
    [Fact]
    public void ApiEndpoints_Users_GetAll_ShouldBeCorrect()
    {
        // Arrange
        const string expected = "/api/users";

        // Act
        const string actual = ApiEndpoints.Users.GetAll;

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void ApiEndpoints_Users_Create_ShouldBeCorrect()
    {
        // Arrange
        const string expected = "/api/users";

        // Act
        const string actual = ApiEndpoints.Users.Create;

        // Assert
        actual.Should().Be(expected);
    }
}