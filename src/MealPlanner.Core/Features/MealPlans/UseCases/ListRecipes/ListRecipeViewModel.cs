using MealPlanner.Domain.Features.MealPlans;

namespace MealPlanner.Core.Features.MealPlans.UseCases.ListRecipes;
public class ListRecipeViewModel
{
    public Guid Id { get; set; }

    public string Title { get; set; } = default!;

    public string? Description { get; set; }

    public RecipeDifficulty Difficulty { get; set; }

    public int TimeToPrepareInMinutes { get; set; }

    public bool ForBreakfast { get; set; }

    public bool ForLunch { get; set; }

    public bool ForDinner { get; set; }

    public bool ForSnack { get; set; }

    public static ListRecipeViewModel FromEntity(Recipe recipe)
    {
        return new ListRecipeViewModel
        {
            Id = recipe.Id,
            Title = recipe.Title,
            Description = recipe.Description,
            Difficulty = recipe.Difficulty,
            TimeToPrepareInMinutes = recipe.TimeToPrepareInMinutes,
            ForBreakfast = recipe.ForBreakfast,
            ForLunch = recipe.ForLunch,
            ForDinner = recipe.ForDinner,
            ForSnack = recipe.ForSnack
        };
    }
}
