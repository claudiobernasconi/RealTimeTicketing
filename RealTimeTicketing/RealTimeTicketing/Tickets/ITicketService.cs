using RealTimeTicketing.Client.Tickets;

namespace RealTimeTicketing.Tickets;

public interface ITicketService
{
    IEnumerable<Ticket> GetTickets();
    void UpdateState(int ticketId, TicketState state);
}
