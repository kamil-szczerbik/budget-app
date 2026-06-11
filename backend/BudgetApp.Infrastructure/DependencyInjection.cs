using BudgetApp.Domain.Interfaces;
using BudgetApp.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BudgetApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<ICurrencyRepository, CurrencyRepository>();
        services.AddScoped<ITransactionCategoryRepository, TransactionCategoryRepository>();
        services.AddScoped<ITransactionRepository, TransactionRepository>();
        services.AddScoped<IWalletRepository, WalletRepository>();
        services.AddScoped<IWalletTypeRepository, WalletTypeRepository>();

        return services;
    }
}