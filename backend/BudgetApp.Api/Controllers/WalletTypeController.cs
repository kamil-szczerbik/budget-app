using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Api.Controllers;

[ApiController]
[Route("api/wallet-types")]
public class WalletTypeController(IWalletTypeRepository repo) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await repo.GetAll());
    }

    [HttpPost]
    public async Task<IActionResult> Add(WalletType walletType)
    {
        await repo.Add(walletType);
        
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await repo.Delete(id);
        
        return Ok();
    }
}