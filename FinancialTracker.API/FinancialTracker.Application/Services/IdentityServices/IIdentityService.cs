namespace FinancialTracker.Application.Services.IdentityServices;

public interface IIdentityService
{
    string GenerateJwtToken(string userId, string userName, string secret);
}
