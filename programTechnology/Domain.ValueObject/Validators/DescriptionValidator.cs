using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public class DescriptionValidator : IValidator<string>
{
    public static int MAX_LENGTH => 1000;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidDescriptionException(value);

        if (value.Length > MAX_LENGTH)
            throw new InvalidDescriptionException(value);
    }
}