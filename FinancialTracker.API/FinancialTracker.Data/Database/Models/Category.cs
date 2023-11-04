namespace FinancialTracker.Data.Database.Models;

using System.ComponentModel.DataAnnotations;

using static FinancialTracker.Data.Database.ValidationConstants.Category;

public class Category
{
    public int Id { get; set; }

    public Guid Identifier { get; set; }

    [Required]
    public string UserId { get; set; }

    public User User { get; set; }

    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string Name { get; set; }

    public ICollection<Transaction> Transactions { get; init; } = new HashSet<Transaction>();
}
