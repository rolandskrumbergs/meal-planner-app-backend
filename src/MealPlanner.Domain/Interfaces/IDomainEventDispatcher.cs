using MealPlanner.Domain.Abstract;

namespace MealPlanner.Domain.Interfaces;
public interface IDomainEventDispatcher
{
    Task DispatchAndClearEvents(IEnumerable<DomainEntity> entitiesWithEvents);
}
