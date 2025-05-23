﻿using MealPlanner.Domain.Abstract;
using MealPlanner.Domain.Interfaces;

namespace MealPlanner.Infrastructure.Events;
//public sealed class DomainEventDispatcher(ChannelWriter<DomainEvent> mediator) : IDomainEventDispatcher
//{
//    private readonly ChannelWriter<DomainEvent> _channelWriter = mediator;

//    public async Task DispatchAndClearEvents(IEnumerable<DomainEntity> entitiesWithEvents)
//    {
//        ArgumentNullException.ThrowIfNull(entitiesWithEvents);

//        foreach (var entity in entitiesWithEvents)
//        {
//            var events = entity.DomainEvents.ToArray();
//            entity.ClearDomainEvents();
//            foreach (var domainEvent in events)
//            {
//                await _channelWriter.WriteAsync(domainEvent).ConfigureAwait(false);
//            }
//        }
//    }
//}

public sealed class DomainEventDispatcher() : IDomainEventDispatcher
{
    public Task DispatchAndClearEvents(IEnumerable<DomainEntity> entitiesWithEvents)
    {
        throw new NotImplementedException();
    }
}