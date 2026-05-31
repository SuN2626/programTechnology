using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public class SlotsValidator : IValidator<int>
{
    public static int MIN_VALUE => 0;

    public static int MAX_VALUE => 20;

    public void Validate(int value)
    {
        if (value < MIN_VALUE)
            throw new InvalidSlotsException(value);

        if (value > MAX_VALUE)
            throw new InvalidSlotsException(value);
    }
}
