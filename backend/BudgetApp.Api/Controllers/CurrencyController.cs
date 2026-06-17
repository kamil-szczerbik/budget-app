using BudgetApp.Api.Mappers;
using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Api.Controllers;

[ApiController]
[Route("api/currencies")]
public class CurrencyController(ICurrencyRepository repo, CurrencyMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var currencies = await repo.GetAll();
        var result = currencies.Select(mapper.ToDTO).ToList();

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Currency currency)
    {
        await repo.Add(currency);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await repo.Delete(id);

        return Ok();
    }
}
