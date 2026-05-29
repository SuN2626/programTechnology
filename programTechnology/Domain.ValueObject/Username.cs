using Domain.Exceptions;

namespace Domain.ValueObject;

public sealed class Username
{
    public string Value { get; }

    private Username(string value)
    {
        Value = value;
    }

    public static Username Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidUsernameException(
                "Username is required");
        }

        if (value.Length < 3)
        {
            throw new InvalidUsernameException(
                "Username too short");
        }

        if (value.Length > 50)
        {
            throw new InvalidUsernameException(
                "Username too long");
        }

        return new Username(value);
    }

    public override string ToString()
    {
        return Value;
    }
}