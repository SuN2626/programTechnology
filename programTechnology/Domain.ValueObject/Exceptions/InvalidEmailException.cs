namespace Domain.ValueObjects.Exceptions;

public class InvalidEmailException(string value)
    : Exception($"Email '{value}' is invalid.")
{
    public string Value => value;
}