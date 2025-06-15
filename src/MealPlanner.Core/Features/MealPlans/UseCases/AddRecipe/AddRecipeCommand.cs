using MealPlanner.Core.Infrastructure;
using MealPlanner.Core.Infrastructure.Mediator;
using MealPlanner.Domain.Features.MealPlans;

namespace MealPlanner.Core.Features.MealPlans.UseCases.AddRecipe;
public sealed class AddRecipeCommand : IRequest<Result>
{
    public string Title { get; set; } = default!;

    public string? Description { get; set; }

    public RecipeDifficulty Difficulty { get; set; }

    public int TimeToPrepareInMinutes { get; set; }

    public bool ForBreakfast { get; set; }

    public bool ForLunch { get; set; }

    public bool ForDinner { get; set; }

    public bool ForSnack { get; set; }

    public ICollection<RecipeIngredient> Ingredients { get; set; } = [];
}