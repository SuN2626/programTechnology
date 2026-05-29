using Domain.ValueObject;

namespace Domain.Entities;

public class Organizer
{
    public Guid Id { get; private set; }

    public CompanyName CompanyName { get; private set; }

    public Email ContactEmail { get; private set; }

    public Phone ContactPhone { get; private set; }

    public Description Description { get; private set; }

    public Rating Rating { get; private set; }

    private Organizer()
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

    public void ChangeRating(Rating rating)
    {
        Rating = rating;
    }
}