using FluentAssertions;
using SDK.Dto.Users.Requests;

namespace SDK.Test.Dto.Users.Requests;

public class CreateUserRequestTests
{
    [Fact]
    public void CreateUserRequest_ShouldInitializePropertiesCorrectly()
    {
        // Arrange
        const string lastName = "Doe";
        const string firstName = "John";
        const string? middleName = "A";
        const string? englishName = "Johnny";
        const string? ssn = "123-45-6789";
        DateTime? dob = new DateTime(1990, 1, 1);
        const bool isMale = true;
        const bool lastNameFirst = false;
        const string username = "johndoe";
        const string password = "password123";
        const string confirmPassword = "password123";

        // Act
        var request = new CreateUserRequest(
            lastName,
            firstName,
            middleName,
            englishName,
            ssn,
            dob,
            isMale,
            lastNameFirst,
            username,
            password,
            confirmPassword
        );

        // Assert
        request.LastName.Should().Be(lastName);
        request.FirstName.Should().Be(firstName);
        request.MiddleName.Should().Be(middleName);
        request.EnglishName.Should().Be(englishName);
        request.SocialSecurityNumber.Should().Be(ssn);
        request.DateOfBirth.Should().Be(dob);
        request.IsMale.Should().Be(isMale);
        request.LastNameFirst.Should().Be(lastNameFirst);
        request.Username.Should().Be(username);
        request.Password.Should().Be(password);
        request.ConfirmPassword.Should().Be(confirmPassword);
    }
}