using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public class DurationMinutesValidator : IValidator<int>
{
    public static int MIN_VALUE => 1;

    public static int MAX_VALUE => 300;

    public void Validate(int value)
    {
        if (value < MIN_VALUE)
            throw new InvalidDurationMinutesException(value);

        if (value > MAX_VALUE)
            throw new InvalidDurationMinutesException(value);
    }
}
