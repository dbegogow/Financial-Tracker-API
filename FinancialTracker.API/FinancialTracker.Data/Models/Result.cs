namespace FinancialTracker.Data.Models;

using System.Net;

public class Result<T>
{
    private readonly List<string> errors;

    public Result(T data)
        : this(data, HttpStatusCode.OK)
    {
    }

    public Result(T data, HttpStatusCode httpStatusCode)
    {
        this.Data = data;
        this.StatusCode = httpStatusCode;
    }

    public T Data { get; set; }

    public HttpStatusCode StatusCode { get; set; }

    public IReadOnlyCollection<string> Errors
        => this.errors;

    public void AddErrors(params string[] messages)
        => this.errors.AddRange(messages);
}
