namespace Domain.Exceptions;

public class InvalidSlotsException : Exception
{
    public InvalidSlotsException(string message)
        : base(message)
    {
    }
}
