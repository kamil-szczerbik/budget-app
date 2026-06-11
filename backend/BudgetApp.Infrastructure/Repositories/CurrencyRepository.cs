using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using BudgetApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Infrastructure.Repositories;

// TODO uprościć do generycznego repo
public class CurrencyRepository(AppDbContext db) : ICurrencyRepository
{
    public Task<List<Currency>> GetAll()
    {
        return db.Currencies.ToListAsync();    
    }

    public async Task Add(Currency currency)
    {
        db.Currencies.Add(currency);
        await db.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await db.Currencies.FindAsync(id);
        
        if (entity is null)
            return;
        
        db.Currencies.Remove(entity);
        await db.SaveChangesAsync();
    }
}