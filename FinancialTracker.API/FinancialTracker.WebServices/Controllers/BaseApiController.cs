namespace FinancialTracker.WebServices.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
[ApiController]
[Route("[controller]")]
public class BaseApiController : ControllerBase
{
}
