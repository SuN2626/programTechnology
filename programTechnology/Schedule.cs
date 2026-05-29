using Domain.ValueObject;

namespace Domain.Entities;

public class Schedule
{
    public Guid Id { get; private set; }

    public Guid QuestId { get; private set; }

    public DateTime StartTime { get; private set; }

    public Slots SlotsTotal { get; private set; }

    public Slots SlotsAvailable { get; private set; }

    private Schedule()
    {
    }

    public Schedule(
        Guid questId,
        DateTime startTime,
        Slots slotsTotal,
        Slots slotsAvailable)
    {
        Id = Guid.NewGuid();

        QuestId = questId;
        StartTime = startTime;
        SlotsTotal = slotsTotal;
        SlotsAvailable = slotsAvailable;
    }

    public void ReserveSlot()
    {
        SlotsAvailable =
            SlotsAvailable - Slots.Create(1);
    }
}