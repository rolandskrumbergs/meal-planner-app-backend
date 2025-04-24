using MealPlanner.Domain.Features.MealPlans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealPlanner.Infrastructure.Data.Configurations.MealPlans;
public sealed class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Not relevant here")]
    public void Configure(EntityTypeBuilder<Ingredient> builder)
    {
        builder.ToTable(nameof(Ingredient));

        builder.Property(recipe => recipe.Name)
            .HasMaxLength(50)
            .IsRequired();
    }
}