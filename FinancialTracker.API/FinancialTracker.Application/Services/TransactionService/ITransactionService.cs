namespace FinancialTracker.Application.Services.TransactionService;

using FinancialTracker.Application.Models;
using FinancialTracker.Application.Models.TransactionModels;

public interface ITransactionService
{
    Task<ServiceReponseModel<IEnumerable<ListTransactionServiceModel>>> GetAll(string userId);
}
