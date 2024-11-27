namespace RealTimeTicketing.Client.Tickets;

public enum TicketState
{
    Open,
    Pending,
    Resolved,
    Closed
}

public record TicketUpdate(int TicketId, TicketState State);
