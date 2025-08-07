using MealPlanner.Core.Infrastructure;
using MealPlanner.Core.Infrastructure.Mediator;
using MealPlanner.Domain.Features.MealPlans;
using MealPlanner.Domain.Interfaces;

namespace MealPlanner.Core.Features.MealPlans.UseCases.ListRecipes;
public sealed class ListRecipesQueryHandler(IRepository<Recipe> recipeRepository) : IRequestHandler<ListRecipesQuery, Result<IEnumerable<ListRecipeViewModel>>>
{
    public async Task<Result<IEnumerable<ListRecipeViewModel>>> Handle(ListRecipesQuery request, CancellationToken cancellationToken)
    {
        var recipes = await recipeRepository.ListAsync(cancellationToken);

        var result = recipes.Select(recipe => ListRecipeViewModel.FromEntity(recipe));

        return Result.Success(result);
    }
}