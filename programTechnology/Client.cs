using Domain.ValueObject;

namespace Domain.Entities;

public class Client
{
    public Guid Id { get; private set; }

    public Username Username { get; private set; }

    public Email Email { get; private set; }

    public Phone Phone { get; private set; }

    private Client()
    {
    }

    public Client(
        Username username,
        Email email,
        Phone phone)
    {
        Id = Guid.NewGuid();

        Username = username;
        Email = email;
        Phone = phone;
    }

    public void ChangePhone(Phone phone)
    {
        Phone = phone;
    }

    public void ChangeEmail(Email email)
    {
        Email = email;
    }
}