using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class Email(string value)
    : ValueObject<string>(new EmailValidator(), value);
