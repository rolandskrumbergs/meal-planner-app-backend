using MealPlanner.Domain.Abstract;

namespace MealPlanner.Domain.Features.MealPlans;
public sealed class Ingredient(string name, int quantity, string unit) : DomainEntity<Guid>
{
    public string Name { get; private set; } = name;
    public int Quantity { get; private set; } = quantity;
    public string Unit { get; private set; } = unit;
}