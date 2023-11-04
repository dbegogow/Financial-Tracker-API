namespace FinancialTracker.WebServices.Models.RequestModels.IdentityModels;

using System.ComponentModel.DataAnnotations;

using static FinancialTracker.Data.Database.ValidationConstants.User;

public class RegisterRequestModel
{
    [Required]
    public string UserName { get; init; }

    [Required]
    [EmailAddress]
    public string Email { get; init; }

    [Required]
    public string Password { get; init; }

    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string FirstName { get; init; }

    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string LastName { get; init; }
}
