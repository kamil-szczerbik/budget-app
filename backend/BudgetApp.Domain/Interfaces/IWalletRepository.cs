using BudgetApp.Domain.Entities;

namespace BudgetApp.Domain.Interfaces;

public interface IWalletRepository
{
    Task<List<Wallet>> GetAll();
    Task Add(Wallet wallet);
    Task Delete(int id);
}