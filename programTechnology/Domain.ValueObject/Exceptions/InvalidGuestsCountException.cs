namespace Domain.ValueObjects.Exceptions;

public class InvalidGuestsCountException(int value)
    : Exception($"Guests count '{value}' is invalid.")
{
    public int Value => value;
}