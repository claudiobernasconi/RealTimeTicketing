namespace RealTimeTicketing.Client.Tickets;

public class Ticket(int ticketId, string title, DateTime created, TicketState state)
{
    public int TicketId { get; set; } = ticketId;
    public string Title { get; set; } = title;
    public DateTime Created { get; set; } = created;
    public TicketState State { get; set; } = state;
}
