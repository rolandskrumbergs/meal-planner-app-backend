using MealPlanner.Domain.Features.MealPlans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealPlanner.Infrastructure.Data.Configurations.MealPlans;
public sealed class RecipeIngredientConfiguration : IEntityTypeConfiguration<RecipeIngredient>
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Not relevant here")]
    public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
    {
        builder.ToTable(nameof(RecipeIngredient));

        builder.Property(recipe => recipe.Quantity)
            .IsRequired();

        builder
            .HasOne(recipeIngredient => recipeIngredient.Recipe)
            .WithMany(recipe => recipe.Ingredients)
            .HasForeignKey(recipeIngredient => recipeIngredient.RecipeId);

        builder
            .HasOne(recipeIngredient => recipeIngredient.Ingredient)
            .WithMany(ingredient => ingredient.Recipes)
            .HasForeignKey(recipeIngredient => recipeIngredient.IngredientId);

        builder
            .HasOne(recipeIngredient => recipeIngredient.Unit)
            .WithMany(unit => unit.Ingredients)
            .HasForeignKey(recipeIngredient => recipeIngredient.UnitId);
    }
}