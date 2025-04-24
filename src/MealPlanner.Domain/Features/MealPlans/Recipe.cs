using MealPlanner.Domain.Abstract;
using MealPlanner.Domain.Interfaces;

namespace MealPlanner.Domain.Features.MealPlans;
public class Recipe : DomainEntity<Guid>, IAggregateRoot
{
    public string Title { get; private set; } = default!;

    public string? Description { get; private set; }

    public RecipeDifficulty Difficulty { get; private set; }

    public int TimeToPrepareInMinutes { get; private set; }

    public bool ForBreakfast { get; private set; }

    public bool ForLunch { get; private set; }

    public bool ForDinner { get; private set; }

    public bool ForSnack { get; private set; }

    public ICollection<RecipeIngredient> Ingredients { get; private set; } = [];

    protected Recipe()
    {
    }

    public Recipe(
        Guid id,
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
        Id = id;
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