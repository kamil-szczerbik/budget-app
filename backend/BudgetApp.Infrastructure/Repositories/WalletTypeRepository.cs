using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using BudgetApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Infrastructure.Repositories;

public class WalletTypeRepository(AppDbContext db) : IWalletTypeRepository
{
    public Task<List<WalletType>> GetAll()
    {
        return db.WalletTypes.ToListAsync();    
    }

    public async Task Add(WalletType currency)
    {
        db.WalletTypes.Add(currency);
        await db.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await db.WalletTypes.FindAsync(id);
        
        if (entity is null)
            return;
        
        db.WalletTypes.Remove(entity);
        await db.SaveChangesAsync();
    }
}