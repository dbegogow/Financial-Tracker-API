namespace FinancialTracker.Data.Repositories.UserRepository;

using System.Threading.Tasks;

using FinancialTracker.Data.Database;
using FinancialTracker.Data.Models;
using FinancialTracker.Data.Models.UserModels;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext data;

    public UserRepository(AppDbContext data)
    {
        this.data = data;
    }

    public Task<Result<bool>> Create(CreateUserModel newUser)
    {
        throw new NotImplementedException();
    }
}
