namespace FinancialTracker.Data.Repositories.TransactionTypeRepository;

using FinancialTracker.Data.Database;

using Microsoft.EntityFrameworkCore;

public class TransactionTypeRepository : ITransactionTypeRepository
{
    private readonly AppDbContext data;

    public TransactionTypeRepository(AppDbContext data)
        => this.data = data;

    public async Task<bool> Exist(int id)
        => await this.data.TransactionTypes
            .AnyAsync(c => c.Id == id);
}
