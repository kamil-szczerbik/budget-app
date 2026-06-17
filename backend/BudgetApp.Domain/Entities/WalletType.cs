using BudgetApp.Domain.Base;

namespace BudgetApp.Domain.Entities;

public class WalletType : Entity
{
    public string Name { get; set; } = null!;
}
