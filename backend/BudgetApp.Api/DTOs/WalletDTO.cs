using BudgetApp.Api.Base;

namespace BudgetApp.Api.DTOs;

public class WalletDTO : DTO
{
    public required string Name { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DeactivatedAt { get; set; }

    public int WalletTypeId { get; set; }
    public int CurrencyId { get; set; }
}
