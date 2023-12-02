namespace FinancialTracker.WebServices.Models.RequestModels.TransactionModels;

using System.ComponentModel.DataAnnotations;

using static FinancialTracker.Data.Database.ValidationConstants.Transaction;

public class CreateTransactionRequestModel
{
    [Range(0, 10_000_000_000)]
    public decimal Amount { get; init; }

    [StringLength(DescriptionMaxLength)]
    public string Description { get; init; }

    public int CategoryId { get; init; }

    public int TransactionTypeId { get; init; }
}
