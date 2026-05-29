namespace Domain.Exceptions;

public class InvalidMoneyException : Exception
{
    public InvalidMoneyException(string message)
        : base(message)
    {
    }
}