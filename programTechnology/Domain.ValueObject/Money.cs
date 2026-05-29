using Domain.Exceptions;

namespace Domain.ValueObject;

public sealed class Money : IComparable<Money>
{
    public decimal Value { get; }

    private Money(decimal value)
    {
        Value = decimal.Round(value, 2);
    }

    public static Money Create(decimal value)
    {
        if (value < 0)
        {
            throw new InvalidMoneyException(
                "Money cannot be negative");
        }

        if (decimal.Round(value, 2) != value)
        {
            throw new InvalidMoneyException(
                "Only 2 decimal places allowed");
        }

        return new Money(value);
    }

    public static Money operator +(Money a, Money b)
    {
        return Create(a.Value + b.Value);
    }

    public static Money operator -(Money a, Money b)
    {
        return Create(a.Value - b.Value);
    }

    public static bool operator >(Money a, Money b)
    {
        return a.Value > b.Value;
    }

    public static bool operator <(Money a, Money b)
    {
        return a.Value < b.Value;
    }

    public static bool operator >=(Money a, Money b)
    {
        return a.Value >= b.Value;
    }

    public static bool operator <=(Money a, Money b)
    {
        return a.Value <= b.Value;
    }

    public int CompareTo(Money? other)
    {
        return Value.CompareTo(other?.Value);
    }

    public override string ToString()
    {
        return Value.ToString("F2");
    }
}