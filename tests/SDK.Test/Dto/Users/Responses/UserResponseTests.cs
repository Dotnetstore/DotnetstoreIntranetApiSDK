using FluentAssertions;
using SDK.Dto.Organization.Users.Responses;

namespace SDK.Test.Dto.Users.Responses;

public class UserResponseTests
{
    [Fact]
    public void UserResponse_ShouldInitializePropertiesCorrectly()
    {
        // Arrange
        var id = Guid.NewGuid();
        const string lastName = "Doe";
        const string firstName = "John";
        const string? middleName = "A";
        const string? englishName = "Johnny";
        const string? ssn = "123-45-6789";
        DateTime? dob = new DateTime(1990, 1, 1);
        const bool isMale = true;
        const bool lastNameFirst = false;
        const bool isBlocked = false;
        const bool isDeleted = false;

        // Act
        var response = new UserResponse(
            id,
            lastName,
            firstName,
            middleName,
            englishName,
            ssn,
            dob,
            isMale,
            lastNameFirst,
            isBlocked,
            isDeleted
        );

        // Assert
        response.Id.Should().Be(id);
        response.LastName.Should().Be(lastName);
        response.FirstName.Should().Be(firstName);
        response.MiddleName.Should().Be(middleName);
        response.EnglishName.Should().Be(englishName);
        response.SocialSecurityNumber.Should().Be(ssn);
        response.DateOfBirth.Should().Be(dob);
        response.IsMale.Should().Be(isMale);
        response.LastNameFirst.Should().Be(lastNameFirst);
        response.IsBlocked.Should().Be(isBlocked);
        response.IsDeleted.Should().Be(isDeleted);
    }
}