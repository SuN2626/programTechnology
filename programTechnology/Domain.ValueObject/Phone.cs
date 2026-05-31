using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class Phone(string value)
    : ValueObject<string>(new PhoneValidator(), value);