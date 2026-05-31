using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class Slots(int value)
    : ValueObject<int>(new SlotsValidator(), value)
{
    public static Slots operator +(Slots a, Slots b)
        => new(a.Value + b.Value);

    public static Slots operator -(Slots a, Slots b)
        => new(a.Value - b.Value);

    public static bool operator >(Slots a, Slots b)
        => a.Value > b.Value;

    public static bool operator <(Slots a, Slots b)
        => a.Value < b.Value;

    public static bool operator >=(Slots a, Slots b)
        => a.Value >= b.Value;

    public static bool operator <=(Slots a, Slots b)
        => a.Value <= b.Value;
}