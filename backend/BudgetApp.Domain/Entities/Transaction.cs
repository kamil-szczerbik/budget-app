using BudgetApp.Domain.Enums;

namespace BudgetApp.Domain.Entities;

public class Transaction
{
    public int Id { get; set; }

    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public TransactionType TransactionType { get; set; }
    public string? Description { get; set; }

    public int? SourceWalletId { get; set; }
    public Wallet? SourceWallet { get; set; }

    public int? DestinationWalletId { get; set; }
    public Wallet? DestinationWallet { get; set; }

    public int? CategoryId { get; set; }
    public TransactionCategory? Category { get; set; }
}
