using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using BudgetApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Infrastructure.Repositories;

public class TransactionCategoryRepository(AppDbContext db) : ITransactionCategoryRepository
{
    public Task<List<TransactionCategory>> GetAll()
    {
        return db.TransactionCategories.ToListAsync();    
    }

    public async Task Add(TransactionCategory currency)
    {
        db.TransactionCategories.Add(currency);
        await db.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await db.TransactionCategories.FindAsync(id);
        
        if (entity is null)
            return;
        
        db.TransactionCategories.Remove(entity);
        await db.SaveChangesAsync();
    }
}