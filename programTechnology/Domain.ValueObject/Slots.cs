using Domain.Exceptions;

namespace Domain.ValueObject;

public sealed class Slots
{
    public int Value { get; }

    private Slots(int value)
    {
        Value = value;
    }

    public static Slots Create(int value)
    {
        if (value < 0)
        {
            throw new InvalidSlotsException(
                "Slots cannot be negative");
        }

        if (value > 20)
        {
            throw new InvalidSlotsException(
                "Maximum slots is 20");
        }

        return new Slots(value);
    }

    public static Slots operator +(Slots a, Slots b)
    {
        return Create(a.Value + b.Value);
    }

    public static Slots operator -(Slots a, Slots b)
    {
        return Create(a.Value - b.Value);
    }

    public static bool operator >(Slots a, Slots b)
    {
        return a.Value > b.Value;
    }

    public static bool operator <(Slots a, Slots b)
    {
        return a.Value < b.Value;
    }

    public static bool operator >=(Slots a, Slots b)
    {
        return a.Value >= b.Value;
    }

    public static bool operator <=(Slots a, Slots b)
    {
        return a.Value <= b.Value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}