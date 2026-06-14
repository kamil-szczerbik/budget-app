using System.Reflection;
using System.Text.Json;

namespace BudgetApp.Infrastructure.Seeding.Seeders;

public static class JsonSeedLoader
{
    public static string Load(string resourceName, Assembly assembly)
    {
        using var stream = assembly.GetManifestResourceStream(resourceName) ?? throw new InvalidOperationException($"Resource not found: {resourceName}");
        using var reader = new StreamReader(stream);

        return reader.ReadToEnd();
    }

    public static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };
}
