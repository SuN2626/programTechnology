using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public class UsernameValidator : IValidator<string>
{
    public static int MIN_LENGTH => 3;
    public static int MAX_LENGTH => 50;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidUsernameException(value);

        if (value.Length < MIN_LENGTH)
            throw new InvalidUsernameException(value);

        if (value.Length > MAX_LENGTH)
            throw new InvalidUsernameException(value);
    }
}