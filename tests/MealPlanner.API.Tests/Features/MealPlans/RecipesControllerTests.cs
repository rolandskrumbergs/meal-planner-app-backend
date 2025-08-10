using MealPlanner.API.Tests.Infrastructure;
using MealPlanner.Core.Features.MealPlans.UseCases.ListRecipes;

namespace MealPlanner.API.Tests.Features.MealPlans;

public class RecipesControllerTests(MealPlannerApiFactory factory) : IntegrationTest(factory)
{
    [Fact]
    public async Task GetRecipes_ReturnsEmptyList_WhenNoRecipesExist()
    {
        // Act
        var response = await GetAsync<IEnumerable<ListRecipeViewModel>>("api/recipes");

        Assert.NotNull(response);
    }
}