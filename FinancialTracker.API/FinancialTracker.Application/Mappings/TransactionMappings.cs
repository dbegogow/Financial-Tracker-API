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
            Date = source.Date,
            Category = source.Category,
            Type = source.Type
        };
}
