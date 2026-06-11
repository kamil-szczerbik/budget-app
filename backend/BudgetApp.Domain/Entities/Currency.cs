namespace BudgetApp.Domain.Entities;

public class Currency
{
    // TODO jak mają być typy w encjach? (nulle, opcjonale, wymagalne, unikalne itp. + nowy .NET i gettery, settery, init itp.)
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
}