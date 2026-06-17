using BudgetApp.Api.Mappers;
using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Api.Controllers;

[ApiController]
[Route("api/transaction-categories")]
public class TransactionCategoryController(ITransactionCategoryRepository repo, TransactionCategoryMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var transactionCategories = await repo.GetAll();
        var result = transactionCategories.Select(mapper.ToDTO).ToList();

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add(TransactionCategory transactionCategory)
    {
        await repo.Add(transactionCategory);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await repo.Delete(id);

        return Ok();
    }
}
