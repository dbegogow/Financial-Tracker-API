namespace FinancialTracker.WebServices.Infrastructure.Extensions;

using FinancialTracker.Infrastructure.Database;

using Microsoft.EntityFrameworkCore;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(
        this IServiceCollection services,
        IConfiguration configuration)
        => services
            .AddDbContext<AppDbContext>(options => options
                .UseSqlServer(configuration.GetDatabaseConfigurations().ConnectionString));
}
