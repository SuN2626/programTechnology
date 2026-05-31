using Domain.ValueObjects;

namespace Domain.Entities;

public class Quest
{
    public Guid Id { get; }

    public Guid OrganizerId { get; }

    public Title Title { get; private set; }
    public string Type { get; private set; }

    public Description Description { get; private set; }

    public Money Price { get; private set; }

    public DurationMinutes DurationMinutes { get; private set; }

    public DateTime CreatedAt { get; private set; }

    protected Quest()
    {
    }

    public Quest(
    Guid organizerId,
    Title title,
    string type,
    Description description,
    Money price,
    DurationMinutes durationMinutes)
    {
        Id = Guid.NewGuid();

        OrganizerId = organizerId;
        Title = title;
        Type = type;
        Description = description;
        Price = price;
        DurationMinutes = durationMinutes;
        CreatedAt = DateTime.UtcNow;
    }

    public bool ChangePrice(Money price)
    {
        if (Price == price)
            return false;

        Price = price;
        return true;
    }

    public bool ChangeTitle(Title title)
    {
        if (Title == title)
            return false;

        Title = title;
        return true;
    }

    public bool ChangeDescription(Description description)
    {
        if (Description == description)
            return false;

        Description = description;
        return true;
    }
}