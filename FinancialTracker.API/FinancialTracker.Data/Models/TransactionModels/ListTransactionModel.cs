namespace FinancialTracker.Data.Models.TransactionModels;

public class ListTransactionModel
{
    public Guid Id { get; init; }

    public decimal Amount { get; init; }

    public string Description { get; init; }

    public DateTime Date { get; init; }

    public string Category { get; init; }

    public string Type { get; init; }
}
