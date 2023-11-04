namespace FinancialTracker.WebServices.Models.RequestModels.IdentityModels;

using System.ComponentModel.DataAnnotations;

public class LoginRequestModel
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }
}
