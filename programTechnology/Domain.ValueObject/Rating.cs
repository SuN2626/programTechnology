using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class Rating(decimal value)
    : ValueObject<decimal>(new RatingValidator(), value)
{
    public static bool operator >(Rating a, Rating b)
        => a.Value > b.Value;

    public static bool operator <(Rating a, Rating b)
        => a.Value < b.Value;

    public static bool operator >=(Rating a, Rating b)
        => a.Value >= b.Value;

    public static bool operator <=(Rating a, Rating b)
        => a.Value <= b.Value;
}
