using BudgetApp.Api.DTOs;
using BudgetApp.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace BudgetApp.Api.Mappers;

[Mapper]
public partial class WalletMapper
{
    [MapProperty(nameof(Wallet.Id), nameof(WalletDTO.Id))]
    [MapProperty(nameof(Wallet.Name), nameof(WalletDTO.Name))]
    [MapProperty(nameof(Wallet.IsActive), nameof(WalletDTO.IsActive))]
    [MapProperty(nameof(Wallet.CreatedAt), nameof(WalletDTO.CreatedAt))]
    [MapProperty(nameof(Wallet.DeactivatedAt), nameof(WalletDTO.DeactivatedAt))]
    [MapProperty(nameof(Wallet.WalletTypeId), nameof(WalletDTO.WalletTypeId))]
    [MapProperty(nameof(Wallet.CurrencyId), nameof(WalletDTO.CurrencyId))]

    [MapperIgnoreSource(nameof(Wallet.WalletType))]
    [MapperIgnoreSource(nameof(Wallet.Currency))]

    public partial WalletDTO ToDTO(Wallet entity);
}
