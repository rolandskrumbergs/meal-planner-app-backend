using MealPlanner.Domain.Abstract;

namespace MealPlanner.Domain.Features.MealPlans;
public class Ingredient : DomainEntity<Guid>
{
    public string Name { get; private set; } = default!;

    public ICollection<RecipeIngredient> Recipes { get; private set; } = [];

    protected Ingredient()
    {
    }

    public Ingredient(
        Guid id,
        string name)
    {
        Id = id;
        Name = name;
    }
}