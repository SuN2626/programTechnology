using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public class GuestsCountValidator : IValidator<int>
{
    public static int MIN_VALUE => 1;

    public static int MAX_VALUE => 20;

    public void Validate(int value)
    {
        if (value < MIN_VALUE)
            throw new InvalidGuestsCountException(value);

        if (value > MAX_VALUE)
            throw new InvalidGuestsCountException(value);
    }
}