using BudgetApp.Api.Base;
using BudgetApp.Domain.Enums;

namespace BudgetApp.Api.DTOs;

public class TransactionDTO : DTO
{
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public TransactionType TransactionType { get; set; }
    public string? Description { get; set; }

    public int? SourceWalletId { get; set; }
    public int? DestinationWalletId { get; set; }
    public int? CategoryId { get; set; }
}
