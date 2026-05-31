using Domain.ValueObjects.Base;
using Domain.ValueObjects.Validators;

namespace Domain.ValueObjects;

public class Title(string value)
    : ValueObject<string>(new TitleValidator(), value);