using System.Text.Json;
using BudgetApp.Domain.Entities;
using BudgetApp.Infrastructure.Seeding.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Infrastructure.Seeding.Seeders;

public static class TransactionCategorySeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var assembly = typeof(TransactionCategorySeeder).Assembly;
        var json = JsonSeedLoader.Load("BudgetApp.Infrastructure.Seeding.Data.transactionCategories.json", assembly);
        var transactionCategories = JsonSerializer.Deserialize<List<TransactionCategorySeedModel>>(json, JsonSeedLoader.JsonOptions);

        if (transactionCategories is null)
            throw new InvalidOperationException("Failed to deserialize transaction categories seed.");

        modelBuilder.Entity<TransactionCategory>().HasData(
            transactionCategories.Select(t => new TransactionCategory
            {
                Id = t.Id,
                Name = t.Name,
                Type = t.Type,
                ParentId = t.ParentId
            })
        );
    }
}
