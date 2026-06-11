using BudgetApp.Domain.Entities;

namespace BudgetApp.Domain.Interfaces;

public interface IWalletTypeRepository
{
    Task<List<WalletType>> GetAll();
    Task Add(WalletType walletType);
    Task Delete(int id);
}