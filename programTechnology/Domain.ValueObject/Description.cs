using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class Description(string value)
    : ValueObject<string>(new DescriptionValidator(), value);