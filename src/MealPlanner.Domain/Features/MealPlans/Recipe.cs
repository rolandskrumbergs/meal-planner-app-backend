using MealPlanner.Domain.Abstract;
using MealPlanner.Domain.Interfaces;

namespace MealPlanner.Domain.Features.MealPlans;
public class Recipe : DomainEntity<Guid>, IAggregateRoot
{
    public string Title { get; protected set; } = default!;

    public string? Description { get; protected set; }

    public RecipeDifficulty Difficulty { get; protected set; }

    public int TimeToPrepareInMinutes { get; protected set; }

    public bool ForBreakfast { get; protected set; }

    public bool ForLunch { get; protected set; }

    public bool ForDinner { get; protected set; }

    public bool ForSnack { get; protected set; }

    public ICollection<RecipeIngredient> Ingredients { get; protected set; } = [];

    protected Recipe()
    {
    }

    public Recipe(
        string title,
        string? description,
        RecipeDifficulty difficulty,
        int timeToPrepareInMinutes,
        bool forBreakfast,
        bool forLunch,
        bool forDinner,
        bool forSnack,
        ICollection<RecipeIngredient> ingredients)
    {
        Title = title;
        Description = description;
        Difficulty = difficulty;
        TimeToPrepareInMinutes = timeToPrepareInMinutes;
        ForBreakfast = forBreakfast;
        ForLunch = forLunch;
        ForDinner = forDinner;
        ForSnack = forSnack;
        Ingredients = ingredients;
    }
}