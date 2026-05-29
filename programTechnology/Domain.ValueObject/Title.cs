using Domain.Exceptions;

namespace Domain.ValueObject;

public sealed class Title
{
    public string Value { get; }

    private Title(string value)
    {
        Value = value;
    }

    public static Title Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidTitleException(
                "Title is required");
        }

        if (value.Length > 100)
        {
            throw new InvalidTitleException(
                "Title too long");
        }

        return new Title(value);
    }

    public override string ToString()
    {
        return Value;
    }
}