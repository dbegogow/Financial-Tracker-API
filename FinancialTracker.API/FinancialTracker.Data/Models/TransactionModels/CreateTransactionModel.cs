namespace FinancialTracker.Data.Models.TransactionModels;

public class CreateTransactionModel
{
    public string UserId { get; init; }

    public decimal Amount { get; init; }

    public string Description { get; init; }

    public DateTime Date { get; init; }

    public Guid CategoryIdentifier { get; init; }

    public Guid TransactionTypeIdentifier { get; init; }

    public DateTime CreatedAt { get; init; }
}
