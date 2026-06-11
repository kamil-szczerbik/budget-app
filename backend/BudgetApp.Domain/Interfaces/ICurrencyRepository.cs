using BudgetApp.Domain.Entities;

namespace BudgetApp.Domain.Interfaces;

public interface ICurrencyRepository
{
    Task<List<Currency>> GetAll();
    Task Add(Currency currency);
    Task Delete(int id);
}