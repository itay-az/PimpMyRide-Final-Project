using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Controllers
{
    [Route("/Tickets")]
    [ApiController]
    public class TicketController : GarageController
    {
        public TicketController()
        {
            this.handler = new TicketsHandler();
        }

        [HttpPost]
        public ActionResult CreateTicket([FromBody] CreateNewTicketRequest request)
        {
            return ((TicketsHandler)handler).HandleCreate(request);
        }

        [HttpGet]
        public ActionResult GetAllTickets()
        {
            return ((TicketsHandler)handler).HandleGet();
        }
        [HttpGet("getTicket/{ticketId}")]
        public ActionResult GetTicketById(int ticketId)
        {
            return ((TicketsHandler)handler).HandlGetById(ticketId);
        }

        [HttpDelete("deleteTicket/{ticketId}")]
        public ActionResult DeleteModel(int ticketId)
        {
            return ((TicketsHandler)handler).HandleDelete(ticketId);
        }
        [HttpPut("addPartToTicket/{ticketId}")]
        public ActionResult AddPartToTicket(int ticketId, [FromBody] TicketPart part)
        {
            return ((TicketsHandler)handler).HandleAddPartToTicket(ticketId,part);
        }

        [HttpDelete("removePartFromTicket/{ticketId}/{partId}")]
        public ActionResult RemovePartFromTicket(int ticketId, string partId)
        {
            return ((TicketsHandler)handler).RemovePartFromTicket(ticketId, partId);
        }
        [HttpPut("updatePartsOnTicket/{ticketId}")]
        public ActionResult UpdatePartsOnTicket(int ticketId, [FromBody]List<TicketPart> parts)
        {
            return ((TicketsHandler)handler).HandleUpdatePartsOnTicket(ticketId, parts);
        }


    }
}
