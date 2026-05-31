using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public class TitleValidator : IValidator<string>
{
    public static int MAX_LENGTH => 100;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidTitleException(value);

        if (value.Length > MAX_LENGTH)
            throw new InvalidTitleException(value);
    }
}