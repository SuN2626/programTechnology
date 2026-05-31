using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class Money(decimal value)
    : ValueObject<decimal>(new MoneyValidator(), value)
{
    public static Money operator +(Money a, Money b)
        => new(a.Value + b.Value);

    public static Money operator -(Money a, Money b)
        => new(a.Value - b.Value);

    public static bool operator >(Money a, Money b)
        => a.Value > b.Value;

    public static bool operator <(Money a, Money b)
        => a.Value < b.Value;

    public static bool operator >=(Money a, Money b)
        => a.Value >= b.Value;

    public static bool operator <=(Money a, Money b)
        => a.Value <= b.Value;
}