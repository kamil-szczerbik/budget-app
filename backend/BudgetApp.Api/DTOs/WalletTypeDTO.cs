using BudgetApp.Api.Base;

namespace BudgetApp.Api.DTOs;

public class WalletTypeDTO : DTO
{
    public required string Name { get; set; }
}
