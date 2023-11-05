namespace FinancialTracker.Data.Repositories.TransactionRepository;

using FinancialTracker.Data.Models.TransactionModels;

public interface ITransactionRepository
{
    Task<IEnumerable<ListTransactionModel>> GetAll(string userId);
}
