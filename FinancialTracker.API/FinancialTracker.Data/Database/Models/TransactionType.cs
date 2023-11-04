namespace FinancialTracker.Infrastructure.Database.Models;

using System.ComponentModel.DataAnnotations;

using static FinancialTracker.Infrastructure.Database.ValidationConstants.TransactionType;

public class TransactionType
{
    public int Id { get; set; }

    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string Name { get; set; }

    public ICollection<Transaction> Transactions { get; init; } = new HashSet<Transaction>();
}
