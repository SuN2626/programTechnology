using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public class CompanyNameValidator : IValidator<string>
{
    public static int MIN_LENGTH => 2;

    public static int MAX_LENGTH => 100;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidCompanyNameException(value);

        if (value.Length < MIN_LENGTH)
            throw new InvalidCompanyNameException(value);

        if (value.Length > MAX_LENGTH)
            throw new InvalidCompanyNameException(value);
    }
}
