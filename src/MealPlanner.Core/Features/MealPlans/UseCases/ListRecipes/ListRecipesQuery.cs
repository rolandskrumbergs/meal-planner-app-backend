using MealPlanner.Core.Infrastructure;
using MealPlanner.Core.Infrastructure.Mediator;

namespace MealPlanner.Core.Features.MealPlans.UseCases.ListRecipes;
public sealed class ListRecipesQuery : IRequest<Result<IEnumerable<ListRecipeViewModel>>>
{
}