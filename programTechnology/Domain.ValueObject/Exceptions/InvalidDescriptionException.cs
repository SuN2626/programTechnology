namespace Domain.Exceptions;

public class InvalidDescriptionException : Exception
{
    public InvalidDescriptionException(string message)
        : base(message)
    {
    }
}