using Domain.ValueObjects.Base;
using Domain.ValueObjects.Exceptions;

namespace Domain.ValueObjects.Validators;

public class MoneyValidator : IValidator<decimal>
{
    public void Validate(decimal value)
    {
        if (value < 0)
            throw new InvalidMoneyException(value);

        if (decimal.Round(value, 2) != value)
            throw new InvalidMoneyException(value);
    }
}
