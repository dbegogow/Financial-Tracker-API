namespace FinancialTracker.Data.Database;

public class ValidationConstants
{
    public class User
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 50;
    }

    public class Category
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 30;
    }

    public class Transaction
    {
        public const int DescriptionMaxLength = 250;
    }

    public class TransactionType
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 15;
    }
}
