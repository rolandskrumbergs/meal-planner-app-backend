using MealPlanner.Domain.Abstract;

namespace MealPlanner.Domain.Features.MealPlans;
public class RecipeIngredient : DomainEntity<Guid>
{
    public Guid RecipeId { get; private set; }
    public Recipe Recipe { get; private set; } = default!;
    public Guid IngredientId { get; private set; }
    public Ingredient Ingredient { get; private set; } = default!;
    public int Quantity { get; private set; }
    public Guid UnitId { get; private set; }
    public Unit Unit { get; private set; } = default!;

    protected RecipeIngredient()
    {
    }

    public RecipeIngredient(
        Recipe recipe,
        Ingredient ingredient,
        int quantity,
        Unit unit)
    {
        Recipe = recipe;
        Ingredient = ingredient;
        Quantity = quantity;
        Unit = unit;
    }
}