namespace FinancialTracker.WebServices.Controllers;

using FinancialTracker.Application.Services.TransactionService;
using FinancialTracker.WebServices.Infrastructure.Mappings;
using FinancialTracker.WebServices.Infrastructure.Services.CurrentUserService;
using FinancialTracker.WebServices.Models.RequestModels.TransactionModels;

using Microsoft.AspNetCore.Mvc;

public class TransactionsController : BaseApiController
{
    private readonly ICurrentUserService currentUserService;
    private readonly ITransactionService transactionService;

    public TransactionsController(
        ICurrentUserService currentUserService,
        ITransactionService transactionService)
    {
        this.currentUserService = currentUserService;
        this.transactionService = transactionService;
    }

    [HttpGet]
    public async Task<IActionResult> All()
    {
        var userId = this.currentUserService.GetId();

        var transactions = await this.transactionService.GetAll(userId);

        return Ok(transactions);
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateTransactionRequestModel transaction)
    {
        var userId = this.currentUserService.GetId();

        var result = await this.transactionService.Create(
            transaction.ToCreateTransactionServiceModel(userId));

        if (result.Errors.Any())
        {
            return BadRequest(result.Errors);
        }

        return Ok(result);
    }
}
