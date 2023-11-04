namespace FinancialTracker.Data.Models;

public class Result<T>
{
    private readonly List<string> errors;

    public Result(T data)
        => this.Data = data;

    public T Data { get; }

    public bool IsSuccessful => !this.errors.Any();

    public IReadOnlyCollection<string> Errors
        => this.errors;

    public void AddErrors(params string[] messages)
        => this.errors.AddRange(messages);
}
