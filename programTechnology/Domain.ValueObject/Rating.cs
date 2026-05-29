using Domain.Exceptions;

namespace Domain.ValueObject;

public sealed class Rating : IComparable<Rating>
{
    public decimal Value { get; }

    private Rating(decimal value)
    {
        Value = value;
    }

    public static Rating Create(decimal value)
    {
        if (value < 0 || value > 5)
        {
            throw new InvalidRatingException(
                "Rating must be between 0 and 5");
        }

        return new Rating(value);
    }

    public static bool operator >(Rating a, Rating b)
    {
        return a.Value > b.Value;
    }

    public static bool operator <(Rating a, Rating b)
    {
        return a.Value < b.Value;
    }

    public static bool operator >=(Rating a, Rating b)
    {
        return a.Value >= b.Value;
    }

    public static bool operator <=(Rating a, Rating b)
    {
        return a.Value <= b.Value;
    }

    public int CompareTo(Rating? other)
    {
        return Value.CompareTo(other?.Value);
    }

    public override string ToString()
    {
        return Value.ToString("F1");
    }
}
