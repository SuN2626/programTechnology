using Domain.ValueObjects.Validators;
using Domain.ValueObjects.Base;

namespace Domain.ValueObjects;

public class CompanyName(string value)
    : ValueObject<string>(new CompanyNameValidator(), value);