using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class DurationMinutes(int value)
    : ValueObject<int>(new DurationMinutesValidator(), value)
{
    public static DurationMinutes operator +(DurationMinutes a, DurationMinutes b)
        => new(a.Value + b.Value);

    public static DurationMinutes operator -(DurationMinutes a, DurationMinutes b)
        => new(a.Value - b.Value);

    public static bool operator >(DurationMinutes a, DurationMinutes b)
        => a.Value > b.Value;

    public static bool operator <(DurationMinutes a, DurationMinutes b)
        => a.Value < b.Value;

    public static bool operator >=(DurationMinutes a, DurationMinutes b)
        => a.Value >= b.Value;

    public static bool operator <=(DurationMinutes a, DurationMinutes b)
        => a.Value <= b.Value;
}