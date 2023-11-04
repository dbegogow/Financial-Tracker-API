namespace FinancialTracker.Data.Repositories.TransactionRepository;

using FinancialTracker.Data.Models;
using FinancialTracker.Data.Models.TransactionModels;

public interface ITransactionRepository
{
    Task<Result<IEnumerable<ListTransactionsModel>>> GetAll(string userId);
}
