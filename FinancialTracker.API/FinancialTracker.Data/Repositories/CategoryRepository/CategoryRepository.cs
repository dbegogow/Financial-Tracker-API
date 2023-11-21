namespace FinancialTracker.Data.Repositories.CategoryRepository;

using System.Threading.Tasks;

using FinancialTracker.Data.Database;

using Microsoft.EntityFrameworkCore;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext data;

    public CategoryRepository(AppDbContext data)
        => this.data = data;

    public async Task<bool> Exist(int id)
        => await this.data.Categories
            .AnyAsync(c => c.Id == id);
}
