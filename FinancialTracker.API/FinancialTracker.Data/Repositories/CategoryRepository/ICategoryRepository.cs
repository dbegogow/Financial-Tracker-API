namespace FinancialTracker.Data.Repositories.CategoryRepository;

public interface ICategoryRepository
{
    Task<bool> Exist(int id);
}
