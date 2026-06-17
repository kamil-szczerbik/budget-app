using BudgetApp.Api.DTOs;
using BudgetApp.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace BudgetApp.Api.Mappers;

[Mapper]
public partial class WalletTypeMapper
{
    [MapProperty(nameof(WalletTypeDTO.Id), nameof(WalletTypeDTO.Id))]
    [MapProperty(nameof(WalletTypeDTO.Name), nameof(WalletTypeDTO.Name))]

    public partial WalletTypeDTO ToDTO(WalletType entity);
}
