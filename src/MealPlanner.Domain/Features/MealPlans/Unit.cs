using MealPlanner.Domain.Abstract;

namespace MealPlanner.Domain.Features.MealPlans;
public sealed class Unit(string name, string? abbreviation = null) : DomainEntity<Guid>
{
    public string Name { get; private set; } = name;
    public string? Abbreviation { get; private set; } = abbreviation;
}