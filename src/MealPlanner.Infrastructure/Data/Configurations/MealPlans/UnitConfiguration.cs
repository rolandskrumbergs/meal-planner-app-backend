using MealPlanner.Domain.Features.MealPlans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MealPlanner.Infrastructure.Data.Configurations.MealPlans;
public sealed class UnitConfiguration : IEntityTypeConfiguration<Unit>
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Not relevant here")]
    public void Configure(EntityTypeBuilder<Unit> builder)
    {
        builder.ToTable(nameof(Unit));

        builder.Property(recipe => recipe.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(recipe => recipe.Abbreviation)
            .HasMaxLength(5)
            .IsRequired();
    }
}