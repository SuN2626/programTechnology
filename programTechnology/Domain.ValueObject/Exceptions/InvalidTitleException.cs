namespace Domain.ValueObjects.Exceptions;

public class InvalidTitleException(string value)
    : Exception($"Title '{value}' is invalid.")
{
    public string Value => value;
}
