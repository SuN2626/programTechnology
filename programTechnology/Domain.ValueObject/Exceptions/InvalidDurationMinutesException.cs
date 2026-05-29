namespace Domain.Exceptions;

public class InvalidDurationMinutesException : Exception
{
    public InvalidDurationMinutesException(
        string message)
        : base(message)
    {
    }
}Ы