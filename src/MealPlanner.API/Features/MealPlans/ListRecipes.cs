using MealPlanner.Core.Features.MealPlans.UseCases.ListRecipes;
using MealPlanner.Core.Infrastructure;
using MealPlanner.Core.Infrastructure.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.API.Features.MealPlans;

[Route("api/recipes")]
[ApiController]
internal sealed class ListRecipes(IRequestHandler<ListRecipesQuery, Result<IEnumerable<ListRecipeViewModel>>> handler) : ControllerBase
{
    private readonly IRequestHandler<ListRecipesQuery, Result<IEnumerable<ListRecipeViewModel>>> _handler = handler;

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<ListRecipeViewModel>>> List([FromBody] ListRecipesQuery request, CancellationToken cancellationToken)
    {
        var result = await _handler.Handle(request, cancellationToken);

        return result.ToActionResult();
    }
}