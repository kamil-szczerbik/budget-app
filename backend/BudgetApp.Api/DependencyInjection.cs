using BudgetApp.Api.Mappers;

namespace BudgetApp.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddSingleton<CurrencyMapper>();
        services.AddSingleton<TransactionMapper>();
        services.AddSingleton<TransactionCategoryMapper>();
        services.AddSingleton<WalletMapper>();
        services.AddSingleton<WalletTypeMapper>();

        return services;
    }
}
