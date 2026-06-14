using BudgetApp.Domain.Entities;
using BudgetApp.Infrastructure.Seeding.Seeders;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Currency> Currencies => Set<Currency>();
    public DbSet<Transaction> Transactions => Set<Transaction>();
    public DbSet<TransactionCategory> TransactionCategories => Set<TransactionCategory>();
    public DbSet<Wallet> Wallets => Set<Wallet>();
    public DbSet<WalletType> WalletTypes => Set<WalletType>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 1
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        // 2
        CurrencySeeder.Seed(modelBuilder);
        TransactionCategorySeeder.Seed(modelBuilder);
    }
}
