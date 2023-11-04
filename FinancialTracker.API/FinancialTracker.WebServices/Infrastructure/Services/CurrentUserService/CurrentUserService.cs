namespace FinancialTracker.WebServices.Infrastructure.Services.CurrentUserService;

using System.Security.Claims;

using FinancialTracker.WebServices.Infrastructure.Extensions;

public class CurrentUserService : ICurrentUserService
{
    private readonly ClaimsPrincipal user;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        => this.user = httpContextAccessor.HttpContext?.User;

    public string GetId()
            => this.user?.GetId();
}
