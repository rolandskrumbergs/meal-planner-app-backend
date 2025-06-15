using MealPlanner.Core.Infrastructure;
using MealPlanner.Core.Infrastructure.Mediator;

namespace MealPlanner.Core.Features.MealPlans.UseCases.ListRecipes;
public sealed class ListRecipesQueryHandler : IRequestHandler<ListRecipesQuery, Result<IEnumerable<ListRecipeViewModel>>>
{
    public async Task<Result<IEnumerable<ListRecipeViewModel>>> Handle(ListRecipesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}