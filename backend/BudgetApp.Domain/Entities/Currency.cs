using BudgetApp.Domain.Base;

namespace BudgetApp.Domain.Entities;

public class Currency : Entity
{
    public string Code { get; set; } = null!;
    public string Symbol { get; set; } = null!;
    public byte DecimalPlaces { get; set; }
}
