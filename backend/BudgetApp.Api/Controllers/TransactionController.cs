using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Api.Controllers;

[ApiController]
[Route("api/transactions")]
public class TransactionController(ITransactionRepository repo) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await repo.GetAll());
    }

    [HttpPost]
    public async Task<IActionResult> Add(Transaction transaction)
    {
        await repo.Add(transaction);
        
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await repo.Delete(id);
        
        return Ok();
    }
}