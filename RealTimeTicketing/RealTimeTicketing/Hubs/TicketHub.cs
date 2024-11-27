using Microsoft.AspNetCore.SignalR;
using RealTimeTicketing.Client.Tickets;
using RealTimeTicketing.Tickets;

namespace RealTimeTicketing.Hubs;

public class TicketHub(ITicketService _ticketService) : Hub
{
    public async Task UpdateTicket(TicketUpdate ticket)
    {
        await Clients.All.SendAsync("ReceiveTicketUpdate", ticket);
        _ticketService.UpdateState(ticket.TicketId, ticket.State);
    }
}
