namespace FinancialTracker.Data.Repositories.TransactionTypeRepository;

public interface ITransactionTypeRepository
{
    Task<bool> Exist(int id);
}
