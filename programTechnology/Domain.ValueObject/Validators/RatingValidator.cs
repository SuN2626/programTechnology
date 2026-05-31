using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public class RatingValidator : IValidator<decimal>
{
    public static decimal MIN_VALUE => 0;

    public static decimal MAX_VALUE => 5;

    public void Validate(decimal value)
    {
        if (value < MIN_VALUE || value > MAX_VALUE)
            throw new InvalidRatingException(value);
    }
}
