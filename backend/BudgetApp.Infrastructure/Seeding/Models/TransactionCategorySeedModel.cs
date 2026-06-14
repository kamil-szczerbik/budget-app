using BudgetApp.Domain.Enums;

namespace BudgetApp.Infrastructure.Seeding.Models;

public class TransactionCategorySeedModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public TransactionCategoryType Type { get; set; }
    public int? ParentId { get; set; }
}
