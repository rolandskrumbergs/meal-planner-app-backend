using MealPlanner.Core.Features.MealPlans.UseCases.ListRecipes;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.API.Features.MealPlans;
[Route("api/[controller]")]
[ApiController]
internal partial class ListRecipes : ControllerBase
{
    private readonly ListRecipesQueryHandler _handler;

    public ListRecipes(ListRecipesQueryHandler handler)
    {
        _handler = handler;
    }

    public async Task<ActionResult<ListRecipesResponse>> List([FromBody] ListRecipesRequest request, CancellationToken cancellationToken)
    {
        var query = new ListRecipesQuery();

        await _handler.Handle(query, cancellationToken);

        return new ListRecipesResponse();
    }
}

internal record ListRecipesRequest();

internal record ListRecipesResponse();