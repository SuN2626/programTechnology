namespace Domain.Exceptions;

public class InvalidRatingException : Exception
{
    public InvalidRatingException(string message)
        : base(message)
    {
    }
}
