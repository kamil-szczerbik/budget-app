using BudgetApp.Domain.Base;

namespace BudgetApp.Domain.Entities;

public class Wallet : Entity
{
    public string Name { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeactivatedAt { get; set; }

    public int WalletTypeId { get; set; }
    public WalletType WalletType { get; set; } = null!;

    public int CurrencyId { get; set; }
    public Currency Currency { get; set; } = null!;
}
