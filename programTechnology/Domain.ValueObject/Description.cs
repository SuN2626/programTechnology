using Domain.Exceptions;

namespace Domain.ValueObject;

public sealed class Description
{
    public string Value { get; }

    private Description(string value)
    {
        Value = value;
    }

    public static Description Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidDescriptionException(
                "Description is required");
        }

        if (value.Length > 1000)
        {
            throw new InvalidDescriptionException(
                "Description too long");
        }

        return new Description(value);
    }

    public override string ToString()
    {
        return Value;
    }
}