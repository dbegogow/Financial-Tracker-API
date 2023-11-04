namespace FinancialTracker.Data.Repositories.TransactionRepository;

using FinancialTracker.Data.Database;
using FinancialTracker.Data.Models;
using FinancialTracker.Data.Models.TransactionModels;

using Microsoft.EntityFrameworkCore;

public class TransactionRepository : ITransactionRepository
{
    private readonly AppDbContext data;

    public TransactionRepository(AppDbContext data)
        => this.data = data;

    public async Task<Result<IEnumerable<ListTransactionsModel>>> GetAll(string userId)
    {
        var transactions = await this.data.Transactions
            .Where(t => t.UserId == userId)
            .Select(t => new ListTransactionsModel
            {
                Id = t.Identifier,
                Amount = t.Amount,
                Description = t.Description,
                Date = t.Date,
                Category = t.Category.Name,
                Type = t.TransactionType.Name
            })
            .AsNoTracking()
            .ToListAsync();

        var result = new Result<IEnumerable<ListTransactionsModel>>(transactions);

        return result;
    }
}
