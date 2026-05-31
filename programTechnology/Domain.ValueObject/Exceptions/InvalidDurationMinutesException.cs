namespace Domain.ValueObjects.Exceptions;

public class InvalidDurationMinutesException(int value)
    : Exception($"Duration '{value}' minutes is invalid.")
{
    public int Value => value;
}