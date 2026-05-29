namespace Domain.Exceptions;

public class InvalidGuestsCountException : Exception
{
    public InvalidGuestsCountException(string message)
        : base(message)
    {
    }
}
