using BudgetApp.Domain.Base;
using BudgetApp.Domain.Enums;

namespace BudgetApp.Domain.Entities;

public class TransactionCategory : Entity
{
    public string Name { get; set; } = null!;
    public TransactionCategoryType Type { get; set; }

    public int? ParentId { get; set; }
    public TransactionCategory? Parent { get; set; }

    public ICollection<TransactionCategory> Children { get; set; } = new List<TransactionCategory>();
}
