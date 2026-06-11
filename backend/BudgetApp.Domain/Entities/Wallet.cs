namespace BudgetApp.Domain.Entities;

public class Wallet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int WalletTypeId { get; set; }
    public int CurrencyId { get; set; }
}