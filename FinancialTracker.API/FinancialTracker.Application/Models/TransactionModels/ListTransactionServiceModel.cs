namespace FinancialTracker.Application.Models.TransactionModels;

public class ListTransactionServiceModel
{
    public Guid Id { get; init; }

    public decimal Amount { get; init; }

    public string Description { get; init; }

    public DateTime CreatedAt { get; init; }

    public string Category { get; init; }

    public string Type { get; init; }
}
