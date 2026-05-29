using Domain.Exceptions;

namespace Domain.ValueObject;

public sealed class CompanyName
{
    public string Value { get; }

    private CompanyName(string value)
    {
        Value = value;
    }

    public static CompanyName Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidCompanyNameException(
                "Company name is required");
        }

        if (value.Length < 2)
        {
            throw new InvalidCompanyNameException(
                "Company name too short");
        }

        if (value.Length > 100)
        {
            throw new InvalidCompanyNameException(
                "Company name too long");
        }

        return new CompanyName(value);
    }

    public override string ToString()
    {
        return Value;
    }
}