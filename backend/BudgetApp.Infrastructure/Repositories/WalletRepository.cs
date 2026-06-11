using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using BudgetApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Infrastructure.Repositories;

public class WalletRepository(AppDbContext db) : IWalletRepository
{
    public Task<List<Wallet>> GetAll()
    {
        return db.Wallets.ToListAsync();    
    }

    public async Task Add(Wallet currency)
    {
        db.Wallets.Add(currency);
        await db.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await db.Wallets.FindAsync(id);
        
        if (entity is null)
            return;
        
        db.Wallets.Remove(entity);
        await db.SaveChangesAsync();
    }
}