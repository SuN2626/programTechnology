using Domain.Exceptions;
using System.Text.RegularExpressions;

namespace Domain.ValueObjects;

public sealed class Email
{
    public string Value { get; }

    private Email(string value)
    {
        Value = value;
    }

    public static Email Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidEmailException(
                "Email cannot be empty");
        }

        if (!Regex.IsMatch(
            value,
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            throw new InvalidEmailException(
                "Invalid email format");
        }

        return new Email(value);
    }

    public override string ToString()
    {
        return Value;
    }
}
