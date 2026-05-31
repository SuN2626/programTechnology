using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Booking
{
    public Guid Id { get; }

    public Guid ClientId { get; }

    public Guid ScheduleId { get; }

    public DateTime BookingDate { get; private set; }

    public GuestsCount GuestsCount { get; private set; }

    public Money TotalPrice { get; private set; }

    public BookingStatus Status { get; private set; }

    protected Booking()
    {
    }

    public Booking(
        Guid clientId,
        Guid scheduleId,
        GuestsCount guestsCount,
        Money totalPrice)
    {
        Id = Guid.NewGuid();

        ClientId = clientId;
        ScheduleId = scheduleId;
        BookingDate = DateTime.UtcNow;
        GuestsCount = guestsCount;
        TotalPrice = totalPrice;

        Status = BookingStatus.Pending;
    }

    public void Confirm()
    {
        Status = BookingStatus.Confirmed;
    }

    public void Cancel()
    {
        Status = BookingStatus.Cancelled;
    }
}