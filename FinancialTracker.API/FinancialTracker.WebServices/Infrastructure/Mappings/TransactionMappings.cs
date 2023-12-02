namespace FinancialTracker.WebServices.Infrastructure.Mappings;

using FinancialTracker.Application.Models.TransactionModels;
using FinancialTracker.WebServices.Models.RequestModels.TransactionModels;

public static class TransactionMappings
{
    public static CreateTransactionServiceModel ToCreateTransactionServiceModel(
        this CreateTransactionRequestModel source,
        string userId)
        => new CreateTransactionServiceModel
        {
            UserId = userId,
            Amount = source.Amount,
            Description = source.Description,
            CategoryId = source.CategoryId,
            TransactionTypeId = source.TransactionTypeId
        };
}
