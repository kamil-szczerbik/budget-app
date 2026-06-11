using BudgetApp.Domain.Enums;

namespace BudgetApp.Domain.Entities;

public class TransactionCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TransactionCategoryType Type { get; set; }
    public int ParentId { get; set; }
}