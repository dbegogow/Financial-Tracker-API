namespace FinancialTracker.Infrastructure.Database.Models;

using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Identity;

using static FinancialTracker.Infrastructure.Database.ValidationConstants.User;

public class User : IdentityUser
{
    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string LastName { get; set; }

    public DateTime CreatedAt { get; set; }

    public ICollection<Transaction> Transactions { get; init; } = new HashSet<Transaction>();

    public ICollection<Category> Categories { get; init; } = new HashSet<Category>();
}
