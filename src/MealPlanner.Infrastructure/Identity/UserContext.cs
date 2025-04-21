using MealPlanner.Domain.Interfaces;

namespace MealPlanner.Infrastructure.Identity;
public sealed class UserContext : IUserContext
{
    public Guid AccountId => throw new NotImplementedException();
}