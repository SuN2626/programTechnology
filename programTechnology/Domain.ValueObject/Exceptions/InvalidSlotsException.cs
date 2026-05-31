namespace Domain.ValueObjects.Exceptions;

public class InvalidSlotsException(int value)
    : Exception($"Slots value '{value}' is invalid.")
{
    public int Value => value;
}
