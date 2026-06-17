using BudgetApp.Api.Base;
using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Enums;

namespace BudgetApp.Api.DTOs;

public class TransactionCategoryDTO : DTO
{
    public required string Name { get; set; }
    public TransactionCategoryType Type { get; set; }
    public int? ParentId { get; set; }
}
