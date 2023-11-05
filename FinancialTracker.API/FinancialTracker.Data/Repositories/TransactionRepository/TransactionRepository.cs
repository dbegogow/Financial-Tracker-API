namespace FinancialTracker.Data.Repositories.TransactionRepository;

using FinancialTracker.Data.Database;
using FinancialTracker.Data.Models.TransactionModels;

using Microsoft.EntityFrameworkCore;

public class TransactionRepository : ITransactionRepository
{
    private readonly AppDbContext data;

    public TransactionRepository(AppDbContext data)
        => this.data = data;

    public async Task<IEnumerable<ListTransactionModel>> GetAll(string userId)
        => await this.data.Transactions
            .Where(t => t.UserId == userId)
            .Select(t => new ListTransactionModel
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
}
