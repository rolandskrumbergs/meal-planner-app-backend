# Meal Planner Backend Architecture Guide

This is a .NET backend application following Domain-Driven Design (DDD) and Clean Architecture principles.

## Project Structure

The solution follows a clean architecture pattern with clear boundaries:

- `MealPlanner.Domain`: Contains business entities and interfaces
- `MealPlanner.Core`: Contains business use cases and application logic
- `MealPlanner.Infrastructure`: Contains data access and external concerns
- `MealPlanner.API`: API layer exposing functionality
- `*.Tests` projects: Contain tests for each main project

## Key Architectural Patterns

1. **Domain-Driven Design**
   - Aggregate roots inherit from `DomainEntity<TId>` 
   - Entities are located in Domain project under feature-specific folders
   - Domain events pattern is used for cross-aggregate communication

2. **CQRS Pattern**
   - Commands and queries are separated into different use cases
   - Use cases follow naming convention: `{Action}{Entity}{Command|Query}Handler`
   - Example: `ListRecipesQueryHandler`, `AddRecipeCommandHandler`

3. **Vertical Slice Architecture**
   - Code is organized by features rather than technical layers
   - Each feature has its own folder containing all related code
   - Example structure:
     ```
     Features/
       MealPlans/
         UseCases/
           AddRecipe/
           ListRecipes/
     ```

4. **Repository Pattern**
   - Generic `IRepository<T>` interface for CRUD operations
   - Repositories handle all data access concerns
   - Repository implementations are in Infrastructure project

5. **Result Pattern**
   - All operations return `Result<T>` or `Result` types
   - Standardized way to handle success/failure and return data
   - Results include status, error messages, and success messages

## Development Workflow

1. **Database Migrations**
   - Use PowerShell and Entity Framework Core tools
   - Set `Operations` as startup project
   - Set `Infrastructure` as default project in Package Manager Console
   - Common commands in `Infrastructure/Data/readme.md`

2. **Testing**
   - Use xUnit for unit tests
   - Tests are organized matching the structure of main projects
   - Integration tests use test containers (in progress)

## Key Technologies

- .NET 9
- Entity Framework Core
- SQL Server
- xUnit
- Azure App Configuration (for settings)

## Best Practices

1. Keep domain logic in Domain project
2. Put use case implementations in Core project
3. Infrastructure concerns belong in Infrastructure project
4. Follow vertical slice architecture when adding new features
5. Use CQRS pattern to separate read and write operations
6. Always return Result objects from handlers
7. Use dependency injection and follow SOLID principles
