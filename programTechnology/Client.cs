using Domain.ValueObjects;

namespace Domain.Entities;

public class Client
{
    public Guid Id { get; }

    public Username Username { get; private set; }

    public Email Email { get; private set; }

    public Phone Phone { get; private set; }

    protected Client()
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

    public bool ChangeEmail(Email email)
    {
        if (Email == email)
            return false;

        Email = email;
        return true;
    }

    public bool ChangePhone(Phone phone)
    {
        if (Phone == phone)
            return false;

        Phone = phone;
        return true;
    }
}