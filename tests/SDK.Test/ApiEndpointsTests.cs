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
        const string actual = ApiEndpoints.Organization.Users.GetAll;

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void ApiEndpoints_Users_Create_ShouldBeCorrect()
    {
        // Arrange
        const string expected = "/api/users";

        // Act
        const string actual = ApiEndpoints.Organization.Users.Create;

        // Assert
        actual.Should().Be(expected);
    }
    
    [Fact]
    public void ApiEndpoints_UserRole_GetAll_ShouldBeCorrect()
    {
        // Arrange
        const string expected = "/api/user-roles";

        // Act
        const string actual = ApiEndpoints.Organization.UserRoles.GetAll;

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void ApiEndpoints_UserRole_Create_ShouldBeCorrect()
    {
        // Arrange
        const string expected = "/api/user-roles";

        // Act
        const string actual = ApiEndpoints.Organization.UserRoles.Create;

        // Assert
        actual.Should().Be(expected);
    }
}