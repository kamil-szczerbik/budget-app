using BudgetApp.Api.Base;

namespace BudgetApp.Api.DTOs;

public class CurrencyDTO : DTO
{
    public required string Code { get; set; }
    public required string Symbol { get; set; }
    public byte DecimalPlaces { get; set; }
}
