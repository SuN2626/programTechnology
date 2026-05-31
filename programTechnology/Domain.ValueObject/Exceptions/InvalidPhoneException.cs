namespace Domain.ValueObjects.Exceptions;

public class InvalidPhoneException(string value)
    : Exception($"Phone '{value}' is invalid.")
{
    public string Value => value;
}