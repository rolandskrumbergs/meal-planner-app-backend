namespace MealPlanner.Core.Features.MealPlans.UseCases;
public sealed class RecipeIngredientModel
{
    public Guid IngredientId { get; set; }
    public int Quantity { get; set; }
    public Guid UnitId { get; set; }
}
