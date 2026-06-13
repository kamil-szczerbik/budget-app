namespace BudgetApp.Domain.Entities;

public class Wallet
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    
    public int WalletTypeId { get; set; }
    public WalletType WalletType { get; set; } = null!;
    
    public int CurrencyId { get; set; }
    public Currency Currency { get; set; } = null!;
}