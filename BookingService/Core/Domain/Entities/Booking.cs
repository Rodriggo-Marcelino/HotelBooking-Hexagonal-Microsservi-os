using Domain.Enums;
using Action = Domain.Enums.Action;

namespace Domain.Entities;

public class Booking
{
    public int Id { get; set; }
    public DateTime PlaceAt { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    private Status Status { get; set; }

    public Status CurrentStatus
    {
        get { return this.Status; }
    }

    public void ChangeState(Action action)
    {
        this.Status = (this.Status, action) switch
        {
            (Enums.Status.Created,  Action.pay) =>     Status.Paid,
            (Enums.Status.Created,  Action.Cancel) =>  Status.Canceled,
            (Enums.Status.Paid,     Action.Finish) =>  Status.Finished,
            (Enums.Status.Paid,     Action.Refound) => Status.Refunded,
            (Enums.Status.Canceled, Action.Reopen) =>  Status.Created,
            _ => this.Status
        };
    }
}
    