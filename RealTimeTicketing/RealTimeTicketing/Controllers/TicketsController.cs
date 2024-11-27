using Microsoft.AspNetCore.Mvc;
using RealTimeTicketing.Client.Tickets;
using RealTimeTicketing.Tickets;

namespace RealTimeTicketing.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketsController(ITicketService _ticketService) : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Ticket>> GetTickets()
    {
        var tickets = _ticketService.GetTickets();
        return Ok(tickets);
    }
}
