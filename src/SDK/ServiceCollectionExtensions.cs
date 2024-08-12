using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace SDK;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDotnetstoreIntranetApi(this IServiceCollection services, string baseUrl)
    {
        services
            .AddHttpClient()
            // .AddSingleton<AuthTokenProvider>()
            .AddRefitClient<IDotnetstoreIntranetApi>(s => new RefitSettings
            {
                // AuthorizationHeaderValueGetter = async () => await s.GetRequiredService<AuthTokenProvider>().GetTokenAsync()
            })
            .ConfigureHttpClient(x =>
                x.BaseAddress = new Uri(baseUrl));
        
        return services;
    }
}