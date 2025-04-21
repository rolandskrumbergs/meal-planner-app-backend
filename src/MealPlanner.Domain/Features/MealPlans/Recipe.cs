using MealPlanner.Domain.Abstract;
using MealPlanner.Domain.Interfaces;

namespace MealPlanner.Domain.Features.MealPlans;
public class Recipe : DomainEntity<Guid>, IAggregateRoot
{
    public string Title { get; private set; }

    public string? Description { get; private set; }

    public RecipeDifficulty Difficulty { get; private set; }

    public int TimeToPrepareInMinutes { get; private set; }

    public IEnumerable<MealTime> MealTimes { get; private set; }

    public IEnumerable<Ingredient> Ingredients { get; private set; }

    protected Recipe()
    {
    }

    public Recipe(
        Guid id,
        string title,
        string? description,
        RecipeDifficulty difficulty,
        int timeToPrepareInMinutes,
        IEnumerable<MealTime> mealTimes,
        IEnumerable<Ingredient> ingredients)
    {
        Id = id;
        Title = title;
        Description = description;
        Difficulty = difficulty;
        TimeToPrepareInMinutes = timeToPrepareInMinutes;
        MealTimes = mealTimes;
        Ingredients = ingredients;
    }
}