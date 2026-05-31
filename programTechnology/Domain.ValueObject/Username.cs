using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class Username(string value)
    : ValueObject<string>(new UsernameValidator(), value);