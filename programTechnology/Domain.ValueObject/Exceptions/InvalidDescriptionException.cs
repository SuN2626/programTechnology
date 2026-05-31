namespace Domain.ValueObjects.Exceptions;

public class InvalidDescriptionException(string value)
    : Exception($"Description is invalid.")
{
    public string Value => value;
}