namespace FinancialTracker.WebServices.Infrastructure.Extensions;

using FinancialTracker.WebServices.Infrastructure.Configurations;

public static class ConfigurationExtensions
{
    public static DatabaseConfiguration GetDatabaseConfigurations(this IConfiguration configuration)
            => configuration.GetSection(nameof(DatabaseConfiguration)).Get<DatabaseConfiguration>();
}
