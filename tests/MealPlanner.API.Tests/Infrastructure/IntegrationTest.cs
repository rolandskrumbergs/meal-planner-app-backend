using System.Net.Http.Json;
using Microsoft.Extensions.DependencyInjection;

namespace MealPlanner.API.Tests.Infrastructure;

public abstract class IntegrationTest : IClassFixture<MealPlannerApiFactory>
{
    protected readonly HttpClient Client;
    protected readonly MealPlannerApiFactory Factory;

    protected IntegrationTest(MealPlannerApiFactory factory)
    {
        Factory = factory;
        Client = factory.CreateClient();
    }

    protected async Task<TResponse?> PostAsync<TResponse>(string url, object? request = null)
    {
        var response = await Client.PostAsJsonAsync(url, request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    protected async Task<TResponse?> GetAsync<TResponse>(string url)
    {
        var response = await Client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    protected T? GetRequiredService<T>() where T : class
    {
        return Factory.Services.GetRequiredService<T>();
    }
}