using MealPlanner.Core.Infrastructure;
using MealPlanner.Core.Infrastructure.Mediator;
using MealPlanner.Domain.Features.MealPlans;
using MealPlanner.Domain.Interfaces;

namespace MealPlanner.Core.Features.MealPlans.UseCases.AddRecipe;
public sealed class AddRecipeCommandHandler(IRepository<Recipe> recipeRepository) : IRequestHandler<AddRecipeCommand, Result>
{
    private readonly IRepository<Recipe> _recipeRepository = recipeRepository;

    public async Task<Result> Handle(AddRecipeCommand command, CancellationToken cancellationToken)
    {
        var recipe = new Recipe(
            command.Title,
            command.Description,
            command.Difficulty,
            command.TimeToPrepareInMinutes,
            command.ForBreakfast,
            command.ForLunch,
            command.ForDinner,
            command.ForSnack,
            [.. command.Ingredients
                .Select(ingredient => new RecipeIngredient(
                    ingredient.IngredientId,
                    ingredient.Quantity,
                    ingredient.UnitId))]);

        await _recipeRepository.AddAsync(recipe, cancellationToken);

        return Result.Created();
    }
}