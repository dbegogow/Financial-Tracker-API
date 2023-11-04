namespace FinancialTracker.Data.Models.UserModels;

public class CreateUserModel
{
    public string Username { get; init; }

    public string Email { get; init; }

    public string Password { get; set; }

    public string FirstName { get; init; }

    public string LastName { get; init; }
}
