using Domain.Exceptions;

namespace Domain.ValueObject;

public sealed class GuestsCount
{
    public int Value { get; }

    private GuestsCount(int value)
    {
        Value = value;
    }

    public static GuestsCount Create(int value)
    {
        if (value <= 0)
        {
            throw new InvalidGuestsCountException(
                "Guests count must be positive");
        }

        if (value > 20)
        {
            throw new InvalidGuestsCountException(
                "Too many guests");
        }

        return new GuestsCount(value);
    }

    public static GuestsCount operator +(
        GuestsCount a,
        GuestsCount b)
    {
        return Create(a.Value + b.Value);
    }

    public static GuestsCount operator -(
        GuestsCount a,
        GuestsCount b)
    {
        return Create(a.Value - b.Value);
    }

    public static bool operator >(
        GuestsCount a,
        GuestsCount b)
    {
        return a.Value > b.Value;
    }

    public static bool operator <(
        GuestsCount a,
        GuestsCount b)
    {
        return a.Value < b.Value;
    }

    public static bool operator >=(
        GuestsCount a,
        GuestsCount b)
    {
        return a.Value >= b.Value;
    }

    public static bool operator <=(
        GuestsCount a,
        GuestsCount b)
    {
        return a.Value <= b.Value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
