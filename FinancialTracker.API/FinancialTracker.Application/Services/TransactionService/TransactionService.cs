namespace FinancialTracker.Application.Services.TransactionService;

using FinancialTracker.Application.Mappings;
using FinancialTracker.Application.Models;
using FinancialTracker.Application.Models.TransactionModels;
using FinancialTracker.Data.Repositories.TransactionRepository;

public class TransactionService : ITransactionService
{
    private readonly ITransactionRepository transactionRepository;

    public TransactionService(ITransactionRepository transactionRepository)
        => this.transactionRepository = transactionRepository;

    public async Task<ServiceReponseModel<IEnumerable<ListTransactionServiceModel>>> GetAll(string userId)
    {
        var transactions = (await this.transactionRepository.GetAll(userId))
            .Data
            .Select(t => t.ToListTransactionServiceModel())
            .ToList();

        var result = new ServiceReponseModel<IEnumerable<ListTransactionServiceModel>>(transactions);

        return result;
    }
}
