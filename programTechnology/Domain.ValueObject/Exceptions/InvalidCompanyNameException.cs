namespace Domain.Exceptions;

public class InvalidCompanyNameException : Exception
{
    public InvalidCompanyNameException(string message)
        : base(message)
    {
    }
}
