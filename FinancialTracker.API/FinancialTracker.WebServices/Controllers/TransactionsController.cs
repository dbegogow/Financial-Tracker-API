namespace FinancialTracker.WebServices.Controllers;

using FinancialTracker.Application.Services.TransactionService;
using FinancialTracker.WebServices.Infrastructure.Services.CurrentUserService;

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
    [Route(nameof(All))]
    public async Task<IActionResult> All()
    {
        var userId = this.currentUserService.GetId();

        var transactions = await this.transactionService.GetAll(userId);

        return Ok(transactions);
    }
}
