using Domain.ValueObject;

namespace Domain.Entities;

public class Quest
{
    public Guid Id { get; private set; }

    public Guid OrganizerId { get; private set; }

    public Title Title { get; private set; }

    public Description Description { get; private set; }

    public Money Price { get; private set; }

    public DurationMinutes DurationMinutes { get; private set; }

    private Quest()
    {
    }

    public Quest(
        Guid organizerId,
        Title title,
        Description description,
        Money price,
        DurationMinutes durationMinutes)
    {
        Id = Guid.NewGuid();

        OrganizerId = organizerId;
        Title = title;
        Description = description;
        Price = price;
        DurationMinutes = durationMinutes;
    }

    public void ChangePrice(Money price)
    {
        Price = price;
    }
}