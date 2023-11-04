using System.ComponentModel.DataAnnotations;

using static FinancialTracker.Infrastructure.Database.ValidationConstants.TransactionType;

namespace FinancialTracker.Infrastructure.Database.Models;

public class TransactionType
{
    public int Id { get; set; }

    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string Name { get; set; }
}
