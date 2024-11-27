using RealTimeTicketing.Client.Tickets;

namespace RealTimeTicketing.Tickets;

public class TicketService : ITicketService
{
    private readonly IList<Ticket> _tickets =
    [
        new Ticket(100, "Monitor does not display image", DateTime.Now, TicketState.Open),
        new Ticket(200, "Internet speed is slow", DateTime.Now, TicketState.Open),
        new Ticket(300, "YouTube video does not play", DateTime.Now, TicketState.Open)
    ];

    public IEnumerable<Ticket> GetTickets()
    {
        return _tickets;
    }

    public void UpdateState(int ticketId, TicketState state)
    {
        var ticket = _tickets.Single(ticket => ticket.TicketId == ticketId);
        ticket.State = state;
    }
}
