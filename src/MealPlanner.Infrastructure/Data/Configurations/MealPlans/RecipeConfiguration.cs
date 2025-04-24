using MealPlanner.Domain.Features.MealPlans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MealPlanner.Infrastructure.Data.Configurations.MealPlans;
public sealed class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Not relevant here")]
    public void Configure(EntityTypeBuilder<Recipe> builder)
    {
        builder.ToTable(nameof(Recipe));

        builder.Property(recipe => recipe.Title)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(recipe => recipe.Description)
            .HasMaxLength(5000)
            .IsRequired(false);

        builder.Property(recipe => recipe.Difficulty)
            .HasMaxLength(10)
            .HasConversion(new EnumToStringConverter<RecipeDifficulty>())
            .IsRequired();
    }
}