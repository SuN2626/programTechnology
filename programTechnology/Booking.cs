using Domain.Enums;
using Domain.ValueObject;

namespace Domain.Entities;

public class Booking
{
    public Guid Id { get; private set; }

    public Guid ClientId { get; private set; }

    public Guid ScheduleId { get; private set; }

    public GuestsCount GuestsCount { get; private set; }

    public Money TotalPrice { get; private set; }

    public BookingStatus Status { get; private set; }

    private Booking()
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