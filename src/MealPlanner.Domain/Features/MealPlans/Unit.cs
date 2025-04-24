using MealPlanner.Domain.Abstract;

namespace MealPlanner.Domain.Features.MealPlans;
public class Unit : DomainEntity<Guid>
{
    public string Name { get; private set; } = default!;
    public string Abbreviation { get; private set; } = default!;
    public ICollection<RecipeIngredient> Ingredients { get; private set; } = [];

    protected Unit()
    {
    }

    public Unit(
        string name,
        string abbreviation)
    {
        Name = name;
        Abbreviation = abbreviation;
    }
}