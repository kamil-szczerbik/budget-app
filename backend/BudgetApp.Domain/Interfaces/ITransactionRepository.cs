using BudgetApp.Domain.Entities;

namespace BudgetApp.Domain.Interfaces;

public interface ITransactionRepository
{
    Task<List<Transaction>> GetAll();
    Task Add(Transaction transaction);
    Task Delete(int id);
}