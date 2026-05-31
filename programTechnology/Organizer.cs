using Domain.ValueObjects;

namespace Domain.Entities;

public class Organizer
{
    public Guid Id { get; }

    public CompanyName CompanyName { get; private set; }

    public Email ContactEmail { get; private set; }

    public Phone ContactPhone { get; private set; }

    public Description Description { get; private set; }

    public Rating Rating { get; private set; }

    protected Organizer()
    {
    }

    public Organizer(
        CompanyName companyName,
        Email contactEmail,
        Phone contactPhone,
        Description description,
        Rating rating)
    {
        Id = Guid.NewGuid();

        CompanyName = companyName;
        ContactEmail = contactEmail;
        ContactPhone = contactPhone;
        Description = description;
        Rating = rating;
    }

    public bool ChangeRating(Rating rating)
    {
        if (Rating == rating)
            return false;

        Rating = rating;
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