namespace Domain.ValueObjects.Exceptions;

public class InvalidCompanyNameException(string value)
    : Exception($"Company name '{value}' is invalid.")
{
    public string Value => value;
}
