using FinancialTracker.Application.Services.TransactionService;
using Microsoft.AspNetCore.Mvc;

namespace FinancialTracker.WebServices.Controllers;

public class TransactionsController : BaseApiController
{
    private readonly ITransactionService transactionService;

    public TransactionsController(ITransactionService transactionService)
        => this.transactionService = transactionService;

    [HttpGet]
    [Route(nameof(All))]
    public async Task<IActionResult> All()
    {

    }
}
