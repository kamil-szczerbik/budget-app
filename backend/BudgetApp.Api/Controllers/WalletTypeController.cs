using BudgetApp.Api.Mappers;
using BudgetApp.Domain.Entities;
using BudgetApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Api.Controllers;

[ApiController]
[Route("api/wallet-types")]
public class WalletTypeController(IWalletTypeRepository repo, WalletTypeMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var walletTypes = await repo.GetAll();
        var result = walletTypes.Select(mapper.ToDTO).ToList();

        return Ok(result);
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
