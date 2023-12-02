namespace FinancialTracker.Application.Services.TransactionService;

using FinancialTracker.Application.Constants;
using FinancialTracker.Application.Mappings;
using FinancialTracker.Application.Models;
using FinancialTracker.Application.Models.TransactionModels;
using FinancialTracker.Data.Repositories.CategoryRepository;
using FinancialTracker.Data.Repositories.TransactionRepository;
using FinancialTracker.Data.Repositories.TransactionTypeRepository;
using System.Net;

public class TransactionService : ITransactionService
{
    private readonly ITransactionRepository transactionRepository;
    private readonly ICategoryRepository categoryRepository;
    private readonly ITransactionTypeRepository transactionTypeRepository;

    public TransactionService(
        ITransactionRepository transactionRepository,
        ICategoryRepository categoryRepository,
        ITransactionTypeRepository transactionTypeRepository)
    {
        this.transactionRepository = transactionRepository;
        this.categoryRepository = categoryRepository;
        this.transactionTypeRepository = transactionTypeRepository;
    }

    public async Task<ServiceReponseModel<IEnumerable<ListTransactionServiceModel>>> GetAll(string userId)
    {
        var transactions = (await this.transactionRepository.GetAll(userId))
            .Select(t => t.ToListTransactionServiceModel())
            .ToList();

        var result = new ServiceReponseModel<IEnumerable<ListTransactionServiceModel>>(transactions);

        return result;
    }

    public async Task<ServiceReponseModel<bool>> Create(CreateTransactionServiceModel transaction)
    {
        var result = new ServiceReponseModel<bool>(HttpStatusCode.BadRequest);

        var isCategoryExistTask = this.categoryRepository
            .Exist(transaction.CategoryId);

        var isTransactionTypeExistTask = this.transactionTypeRepository
            .Exist(transaction.TransactionTypeId);

        await Task.WhenAll(isCategoryExistTask, isTransactionTypeExistTask);

        if (!isCategoryExistTask.Result)
        {
            result.AddErrors(ErrorMessageConstants.InvalidCategoryId);
        }

        if (!isTransactionTypeExistTask.Result)
        {
            result.AddErrors(ErrorMessageConstants.InvalidTransactionTypeId);
        }

        if (result.Errors.Any())
        {
            return result;
        }

        await this.transactionRepository.Create(
            transaction.ToCreateTransactionModel());

        result.SetStatusCode(HttpStatusCode.OK);

        return result;
    }
}
