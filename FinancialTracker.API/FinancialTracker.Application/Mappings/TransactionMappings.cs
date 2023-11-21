namespace FinancialTracker.Application.Mappings;

using FinancialTracker.Application.Models.TransactionModels;
using FinancialTracker.Data.Models.TransactionModels;

public static class TransactionMappings
{
    public static ListTransactionServiceModel ToListTransactionServiceModel(
        this ListTransactionModel source)
        => new ListTransactionServiceModel
        {
            Id = source.Id,
            Amount = source.Amount,
            Description = source.Description,
            CreatedAt = source.CreatedAt,
            Category = source.Category,
            Type = source.Type
        };
}
