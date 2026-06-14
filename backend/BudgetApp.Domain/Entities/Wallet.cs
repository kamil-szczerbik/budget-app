namespace BudgetApp.Domain.Entities;

public class Wallet
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeactivatedAt { get; set; }

    public int WalletTypeId { get; set; }
    public WalletType WalletType { get; set; } = null!;

    public int CurrencyId { get; set; }
    public Currency Currency { get; set; } = null!;
}
