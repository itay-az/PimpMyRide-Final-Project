using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;
using System.IO;

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

        [HttpPost("createLabor")]
        public ActionResult CreateLabor([FromBody] Labor labor)
        {
            return ((TicketsHandler)handler).HandleCreateLabor(labor);
        }
        [HttpGet("getLabors")]
        public ActionResult GetLabors()
        {
            return ((TicketsHandler)handler).HandleGetLabors();
        }

        [HttpGet("getLabors/{id}")]
        public ActionResult GetLaborById(int id) 
        {
            return ((TicketsHandler)handler).HandleGetLaborById(id);
        }

        [HttpPut("updateLaborByid/{id}")]
        public ActionResult UpdateLaborById(int id, [FromBody] Labor labor)
        {
            return ((TicketsHandler)handler).HandleUpdateLaborById(id, labor);
        }

        [HttpDelete("deleteLaborById/{id}")]
        public ActionResult DeleteLaborById(int id)
        {
            return ((TicketsHandler)handler).HandleDeleteLaborById(id);
        }


    }
}
