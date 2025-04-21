namespace MealPlanner.Domain.Interfaces;
public interface IDateTimeProvider
{
    DateTimeOffset UtcNow { get; }
}