using Microsoft.AspNetCore.SignalR;

namespace RealTimeTicketing.Hubs;

public class TicketHub : Hub
{
    public async Task UpdateTicket(string ticketId, string status)
    {
        await Clients.All.SendAsync("ReceiveTicketUpdate", ticketId, status);
    }
}
