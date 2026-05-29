using Domain.Exceptions;
using System.Text.RegularExpressions;

namespace Domain.ValueObjects;

public sealed class Phone
{
    public string Value { get; }

    private Phone(string value)
    {
        Value = value;
    }

    public static Phone Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidPhoneException(
                "Phone is required");
        }

        if (!Regex.IsMatch(
            value,
            @"^\+?[0-9]{10,15}$"))
        {
            throw new InvalidPhoneException(
                "Invalid phone");
        }

        return new Phone(value);
    }

    public override string ToString()
    {
        return Value;
    }
}