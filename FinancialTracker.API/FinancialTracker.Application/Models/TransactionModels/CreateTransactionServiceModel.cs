namespace FinancialTracker.Application.Models.TransactionModels;

public class CreateTransactionServiceModel
{
    public string UserId { get; init; }

    public decimal Amount { get; init; }

    public string Description { get; init; }

    public int CategoryId { get; init; }

    public int TransactionTypeId { get; init; }
}
