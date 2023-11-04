namespace FinancialTracker.Data.Repositories.UserRepository;

using FinancialTracker.Data.Models;
using FinancialTracker.Data.Models.UserModels;

public interface IUserRepository
{
    Task<Result<bool>> Create(CreateUserModel newUser);
}
