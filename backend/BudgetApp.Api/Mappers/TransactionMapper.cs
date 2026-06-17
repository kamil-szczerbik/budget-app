using BudgetApp.Api.DTOs;
using BudgetApp.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace BudgetApp.Api.Mappers;

[Mapper]
public partial class TransactionMapper
{
    [MapProperty(nameof(Transaction.Id), nameof(TransactionDTO.Id))]
    [MapProperty(nameof(Transaction.Date), nameof(TransactionDTO.Date))]
    [MapProperty(nameof(Transaction.Amount), nameof(TransactionDTO.Amount))]
    [MapProperty(nameof(Transaction.TransactionType), nameof(TransactionDTO.TransactionType))]
    [MapProperty(nameof(Transaction.Description), nameof(TransactionDTO.Description))]
    [MapProperty(nameof(Transaction.SourceWalletId), nameof(TransactionDTO.SourceWalletId))]
    [MapProperty(nameof(Transaction.DestinationWalletId), nameof(TransactionDTO.DestinationWalletId))]
    [MapProperty(nameof(Transaction.CategoryId), nameof(TransactionDTO.CategoryId))]

    [MapperIgnoreSource(nameof(Transaction.SourceWallet))]
    [MapperIgnoreSource(nameof(Transaction.DestinationWallet))]
    [MapperIgnoreSource(nameof(Transaction.Category))]

    public partial TransactionDTO ToDTO(Transaction entity);
}
