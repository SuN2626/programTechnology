using Domain.Exceptions;

namespace Domain.ValueObject;

public sealed class DurationMinutes
{
    public int Value { get; }

    private DurationMinutes(int value)
    {
        Value = value;
    }

    public static DurationMinutes Create(int value)
    {
        if (value <= 0)
        {
            throw new InvalidDurationMinutesException(
                "Duration must be positive");
        }

        if (value > 300)
        {
            throw new InvalidDurationMinutesException(
                "Duration too long");
        }

        return new DurationMinutes(value);
    }

    public static DurationMinutes operator +(
        DurationMinutes a,
        DurationMinutes b)
    {
        return Create(a.Value + b.Value);
    }

    public static DurationMinutes operator -(
        DurationMinutes a,
        DurationMinutes b)
    {
        return Create(a.Value - b.Value);
    }

    public static bool operator >(
        DurationMinutes a,
        DurationMinutes b)
    {
        return a.Value > b.Value;
    }

    public static bool operator <(
        DurationMinutes a,
        DurationMinutes b)
    {
        return a.Value < b.Value;
    }

    public static bool operator >=(
        DurationMinutes a,
        DurationMinutes b)
    {
        return a.Value >= b.Value;
    }

    public static bool operator <=(
        DurationMinutes a,
        DurationMinutes b)
    {
        return a.Value <= b.Value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}