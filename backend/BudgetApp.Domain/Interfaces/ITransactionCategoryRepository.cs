using BudgetApp.Domain.Entities;

namespace BudgetApp.Domain.Interfaces;

public interface ITransactionCategoryRepository
{
    Task<List<TransactionCategory>> GetAll();
    Task Add(TransactionCategory transactionCategory);
    Task Delete(int id);
}