using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class GuestsCount(int value)
    : ValueObject<int>(new GuestsCountValidator(), value)
{
    public static GuestsCount operator +(GuestsCount a, GuestsCount b)
        => new(a.Value + b.Value);

    public static GuestsCount operator -(GuestsCount a, GuestsCount b)
        => new(a.Value - b.Value);

    public static bool operator >(GuestsCount a, GuestsCount b)
        => a.Value > b.Value;

    public static bool operator <(GuestsCount a, GuestsCount b)
        => a.Value < b.Value;

    public static bool operator >=(GuestsCount a, GuestsCount b)
        => a.Value >= b.Value;

    public static bool operator <=(GuestsCount a, GuestsCount b)
        => a.Value <= b.Value;
}