namespace FinancialTracker.WebServices.Controllers;

using FinancialTracker.Application.Services.IdentityService;
using FinancialTracker.Data.Database.Models;
using FinancialTracker.WebServices.Infrastructure.Extensions;
using FinancialTracker.WebServices.Models.RequestModels.IdentityModels;
using FinancialTracker.WebServices.Models.ResponseModels.IdentityModels;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public class IdentityController : BaseApiController
{
    private readonly UserManager<User> userManager;
    private readonly IIdentityService identityService;
    private readonly IConfiguration configuration;

    public IdentityController(
        UserManager<User> userManager,
        IIdentityService identityService,
        IConfiguration configuration)
    {
        this.userManager = userManager;
        this.identityService = identityService;
        this.configuration = configuration;
    }

    [HttpPost]
    [AllowAnonymous]
    [Route(nameof(Register))]
    public async Task<ActionResult> Register(RegisterRequestModel model)
    {
        var user = new User
        {
            UserName = model.UserName,
            Email = model.Email,
            FirstName = model.FirstName,
            LastName = model.LastName,
            CreatedAt = DateTime.UtcNow
        };

        var result = await this.userManager.CreateAsync(user, model.Password);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        return Ok();
    }

    [HttpPost]
    [AllowAnonymous]
    [Route(nameof(Login))]
    public async Task<ActionResult<LoginResponseModel>> Login(LoginRequestModel model)
    {
        var user = await this.userManager.FindByNameAsync(model.UserName);

        if (user == null)
        {
            return Unauthorized();
        }

        var passwordValid = await this.userManager.CheckPasswordAsync(user, model.Password);

        if (!passwordValid)
        {
            return Unauthorized();
        }

        var jwtConfiguration = this.configuration.GetJwtConfiguration();

        var token = this.identityService.GenerateJwtToken(
            user.Id,
            user.UserName,
            jwtConfiguration.Secret);

        return new LoginResponseModel
        {
            Token = token
        };
    }
}
