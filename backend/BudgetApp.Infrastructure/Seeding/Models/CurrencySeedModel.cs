namespace BudgetApp.Infrastructure.Seeding.Models;

public class CurrencySeedModel
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public string Symbol { get; set; } = null!;
    public byte DecimalPlaces { get; set; }
}
