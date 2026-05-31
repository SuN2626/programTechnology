namespace Domain.ValueObjects.Exceptions;

public class InvalidRatingException(decimal value)
    : Exception($"Rating '{value}' must be between 0 and 5.")
{
    public decimal Value => value;
}