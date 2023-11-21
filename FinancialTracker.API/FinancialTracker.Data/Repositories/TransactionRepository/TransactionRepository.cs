namespace FinancialTracker.Data.Repositories.TransactionRepository;

using FinancialTracker.Data.Database;
using FinancialTracker.Data.Database.Models;
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
                CreatedAt = t.CreatedAt,
                Category = t.Category.Name,
                Type = t.TransactionType.Name
            })
            .AsNoTracking()
            .ToListAsync();

    public async Task Create(CreateTransactionModel newTransaction)
    {
        var transaction = new Transaction
        {
            UserId = newTransaction.UserId,
            Amount = newTransaction.Amount,
            Description = newTransaction.Description,
            CategoryId = newTransaction.CategoryId,
            TransactionTypeId = newTransaction.TransactionTypeId,
            CreatedAt = DateTime.UtcNow
        };

        this.data.Transactions.Add(transaction);

        await this.data.SaveChangesAsync();
    }
}
