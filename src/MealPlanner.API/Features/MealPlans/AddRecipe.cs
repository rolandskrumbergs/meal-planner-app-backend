using MealPlanner.Core.Features.MealPlans.UseCases.AddRecipe;
using MealPlanner.Core.Infrastructure;
using MealPlanner.Core.Infrastructure.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.API.Features.MealPlans;

[Route("api/[controller]")]
[ApiController]
internal sealed class AddRecipe(IRequestHandler<AddRecipeCommand, Result> handler) : ControllerBase
{
    private readonly IRequestHandler<AddRecipeCommand, Result> _handler = handler;

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] AddRecipeCommand request, CancellationToken cancellationToken)
    {
        var result = await _handler.Handle(request, cancellationToken);

        return result.ToActionResult();
    }
}
