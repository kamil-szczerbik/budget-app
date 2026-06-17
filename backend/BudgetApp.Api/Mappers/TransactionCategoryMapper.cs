using BudgetApp.Api.DTOs;
using BudgetApp.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace BudgetApp.Api.Mappers;

[Mapper]
public partial class TransactionCategoryMapper
{
    [MapProperty(nameof(TransactionCategory.Id), nameof(TransactionCategoryDTO.Id))]
    [MapProperty(nameof(TransactionCategory.Name), nameof(TransactionCategoryDTO.Name))]
    [MapProperty(nameof(TransactionCategory.Type), nameof(TransactionCategoryDTO.Type))]
    [MapProperty(nameof(TransactionCategory.ParentId), nameof(TransactionCategoryDTO.ParentId))]

    [MapperIgnoreSource(nameof(TransactionCategory.Children))]
    [MapperIgnoreSource(nameof(TransactionCategory.Parent))]

    public partial TransactionCategoryDTO ToDTO(TransactionCategory entity);
}
