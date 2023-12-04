using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;
using System.Collections.Generic;
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

        [HttpPut("addLaborToTicket/{ticketId}")]
        public ActionResult AddLaborToTicket(int ticketId,[FromBody] TicketLabor labor)
        {
            return ((TicketsHandler)handler).HandleAddLaborToTicket(ticketId, labor);
        }

        [HttpDelete("removeLaborFromTicket/{ticketId}/{laborId}")]
        public ActionResult RemoveLaborFromTicket(int ticketId, int laborId)
        {
            return ((TicketsHandler)handler).HandleRemoveLaborFromTicket(ticketId, laborId);
        }

        [HttpPut("updateLaborsOnTicket/{ticketId}")]
        public ActionResult UpdateLaborsOnTicket(int ticketId, [FromBody]List<TicketLabor> laborsFromBody)
        {
            return ((TicketsHandler)handler).HandleUpdateLaborOnTicket(ticketId, laborsFromBody);
        }

        [HttpGet("searchLabor/{searchParameter}")]
        public ActionResult SearchLaborByParameter(string searchParameter)
        {
            return ((TicketsHandler)handler).HandleSearchByParameter(searchParameter);
        }

        [HttpDelete("closeTicket/{ticketId}")]
        public ActionResult CloseTicketById(int ticketId)
        {
            return ((TicketsHandler)handler).HandleCloseTicketById(ticketId);

        }
        [HttpPost("createOffer")]
        public ActionResult CreateNewOffer([FromBody] CreateNewTicketRequest request)
        {
            return ((TicketsHandler)handler).HandleCreateOffer(request);
        }

        [HttpGet("searchTicketByCarNumber/{carNumber}")]
        public ActionResult SearchTicketByCarNumber(string carNumber)
        {
            return ((TicketsHandler)handler).SearchTicketByCarNumber(carNumber);
        }
        [HttpGet("searchOfferByCarNumber/{carNumber}")]
        public ActionResult SearchOfferByCarNumber(string carNumber)
        {
            return ((TicketsHandler)handler).SearchOfferByCarNumber(carNumber);
        }

        [HttpPut("updateOfferToTicket/{ticketId}")]
        public ActionResult UpdateOfferToTicket(string ticketId)
        {
            return ((TicketsHandler)handler).UpdateOfferToTicket(int.Parse(ticketId));
        }
    }


   
}
