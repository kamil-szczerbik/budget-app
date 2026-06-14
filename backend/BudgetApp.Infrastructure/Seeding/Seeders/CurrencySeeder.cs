using System.Text.Json;
using BudgetApp.Domain.Entities;
using BudgetApp.Infrastructure.Seeding.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Infrastructure.Seeding.Seeders;

public static class CurrencySeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var assembly = typeof(CurrencySeeder).Assembly;
        var json = JsonSeedLoader.Load("BudgetApp.Infrastructure.Seeding.Data.currencies.json", assembly);
        var currencies = JsonSerializer.Deserialize<List<CurrencySeedModel>>(json, JsonSeedLoader.JsonOptions);

        if (currencies is null)
            throw new InvalidOperationException("Failed to deserialize currencies seed.");

        modelBuilder.Entity<Currency>().HasData(
            currencies.Select(c => new Currency
            {
                Id = c.Id,
                Code = c.Code,
                Symbol = c.Symbol,
                DecimalPlaces = c.DecimalPlaces
            })
        );
    }
}
