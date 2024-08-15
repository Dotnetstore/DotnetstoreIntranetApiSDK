using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace SDK.Test;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddDotnetstoreIntranetApi_ShouldConfigureServicesCorrectly()
    {
        // Arrange
        var services = new ServiceCollection();
        const string baseUrl = "https://example.com";

        // Act
        services.AddDotnetstoreIntranetApi(baseUrl);
        var serviceProvider = services.BuildServiceProvider();

        // Assert
        var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
        httpClientFactory.Should().NotBeNull();

        var apiClient = serviceProvider.GetService<IOrganizationDotnetstoreIntranetApi>();
        apiClient.Should().NotBeNull();
    }
}