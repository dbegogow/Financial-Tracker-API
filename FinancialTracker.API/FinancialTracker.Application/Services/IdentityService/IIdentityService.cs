namespace FinancialTracker.Application.Services.IdentityService;

public interface IIdentityService
{
    string GenerateJwtToken(string userId, string userName, string secret);
}
