namespace Domain.ValueObjects.Exceptions;

public class InvalidUsernameException(string value)
    : Exception($"Username '{value}' is invalid.")
{
    public string Value => value;
}