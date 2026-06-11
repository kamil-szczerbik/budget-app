using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using BudgetApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Infrastructure.Repositories;

public class TransactionRepository(AppDbContext db) : ITransactionRepository
{
    public Task<List<Transaction>> GetAll()
    {
        return db.Transactions.ToListAsync();    
    }

    public async Task Add(Transaction currency)
    {
        db.Transactions.Add(currency);
        await db.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await db.Transactions.FindAsync(id);
        
        if (entity is null)
            return;
        
        db.Transactions.Remove(entity);
        await db.SaveChangesAsync();
    }
}