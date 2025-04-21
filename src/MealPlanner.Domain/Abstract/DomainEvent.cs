namespace MealPlanner.Domain.Abstract;
public abstract class DomainEvent
{
    public DateTimeOffset DateOccurred { get; protected set; } = DateTimeOffset.UtcNow;
}
