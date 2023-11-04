namespace FinancialTracker.WebServices.Infrastructure.Extensions;

using FinancialTracker.WebServices.Infrastructure.Configurations;

public static class ConfigurationExtensions
{
    public static DatabaseConfiguration GetDatabaseConfiguration(this IConfiguration configuration)
            => configuration.GetSection(nameof(DatabaseConfiguration)).Get<DatabaseConfiguration>();

    public static JwtConfiguration GetJwtConfiguration(this IConfiguration configuration)
            => configuration.GetSection(nameof(JwtConfiguration)).Get<JwtConfiguration>();
}
