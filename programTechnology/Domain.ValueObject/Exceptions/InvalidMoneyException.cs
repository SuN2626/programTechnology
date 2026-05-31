namespace Domain.ValueObjects.Exceptions;

public class InvalidMoneyException(decimal value)
    : Exception($"Money value '{value}' is invalid.")
{
    public decimal Value => value;
}