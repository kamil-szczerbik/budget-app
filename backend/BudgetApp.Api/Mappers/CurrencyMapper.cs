using BudgetApp.Api.DTOs;
using BudgetApp.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace BudgetApp.Api.Mappers;

[Mapper]
public partial class CurrencyMapper
{
    [MapProperty(nameof(Currency.Id), nameof(CurrencyDTO.Id))]
    [MapProperty(nameof(Currency.Code), nameof(CurrencyDTO.Code))]
    [MapProperty(nameof(Currency.Symbol), nameof(CurrencyDTO.Symbol))]
    [MapProperty(nameof(Currency.DecimalPlaces), nameof(CurrencyDTO.DecimalPlaces))]
    public partial CurrencyDTO ToDTO(Currency entity);
}
