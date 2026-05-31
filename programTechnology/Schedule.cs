using Domain.ValueObjects;

namespace Domain.Entities;

public class Schedule
{
    public Guid Id { get; }

    public Guid QuestId { get; }

    public DateTime StartTime { get; }

    public Slots SlotsTotal { get; }

    public Slots SlotsAvailable { get; private set; }

    protected Schedule()
    {
    }

    public Schedule(
        Guid questId,
        DateTime startTime,
        Slots slotsTotal)
    {
        Id = Guid.NewGuid();

        QuestId = questId;
        StartTime = startTime;

        SlotsTotal = slotsTotal;
        SlotsAvailable = slotsTotal;
    }

    public bool ReserveSlot()
    {
        if (SlotsAvailable <= new Slots(0))
            return false;

        SlotsAvailable = SlotsAvailable - new Slots(1);

        return true;
    }
}