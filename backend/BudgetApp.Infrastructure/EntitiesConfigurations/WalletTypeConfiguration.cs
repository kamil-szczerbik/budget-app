using BudgetApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetApp.Infrastructure.EntitiesConfigurations;

public class WalletTypeConfiguration : IEntityTypeConfiguration<WalletType>
{
    public void Configure(EntityTypeBuilder<WalletType> builder)
    {
        builder.ToTable("wallet_types");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
