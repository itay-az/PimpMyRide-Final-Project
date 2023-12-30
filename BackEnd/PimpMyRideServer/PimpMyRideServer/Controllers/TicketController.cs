using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;
using System.Collections.Generic;
using System.IO;

namespace PimpMyRideServer.Controllers
{
    // base route controller for tickets that inherits from GarageController
    [Route("/Tickets")]
    [ApiController]
    public class TicketController : GarageController
    {
        // assigning the tickets handler to the controllers
        public TicketController()
        {
            this.handler = new TicketsHandler();
        }



        // post request to create new ticket controller
        [HttpPost]
        public ActionResult CreateTicket([FromBody] CreateNewTicketRequest request)
        {
            return ((TicketsHandler)handler).HandleCreate(request);
        }

        // get request for retriving all tickets
        [HttpGet]
        public ActionResult GetAllTickets()
        {
            return ((TicketsHandler)handler).HandleGet();
        }
        
        // get request for retriving a single ticket given its id
        [HttpGet("getTicket/{ticketId}")]
        public ActionResult GetTicketById(int ticketId)
        {
            return ((TicketsHandler)handler).HandlGetById(ticketId);
        }

        // delete request for deleting a single ticket given its id
        [HttpDelete("deleteTicket/{ticketId}")]
        public ActionResult DeleteModel(int ticketId)
        {
            return ((TicketsHandler)handler).HandleDelete(ticketId);
        }

        // put request for updating a specific ticket given its id
        [HttpPut("addPartToTicket/{ticketId}")]
        public ActionResult AddPartToTicket(int ticketId, [FromBody] TicketPart part)
        {
            return ((TicketsHandler)handler).HandleAddPartToTicket(ticketId,part);
        }

        // delete request for deleting a specific part from a specific ticket
        [HttpDelete("removePartFromTicket/{ticketId}/{partId}")]
        public ActionResult RemovePartFromTicket(int ticketId, string partId)
        {
            return ((TicketsHandler)handler).RemovePartFromTicket(ticketId, partId);
        }

        // put request for updating parts on a specific ticket
        [HttpPut("updatePartsOnTicket/{ticketId}")]
        public ActionResult UpdatePartsOnTicket(int ticketId, [FromBody]List<TicketPart> parts)
        {
            return ((TicketsHandler)handler).HandleUpdatePartsOnTicket(ticketId, parts);
        }


        // put request for adding labor to ticket
        [HttpPut("addLaborToTicket/{ticketId}")]
        public ActionResult AddLaborToTicket(int ticketId, [FromBody] TicketLabor labor)
        {
            return ((TicketsHandler)handler).HandleAddLaborToTicket(ticketId, labor);
        }

        // delete request for removing a specific labor from a specific ticket
        [HttpDelete("removeLaborFromTicket/{ticketId}/{laborId}")]
        public ActionResult RemoveLaborFromTicket(int ticketId, int laborId)
        {
            return ((TicketsHandler)handler).HandleRemoveLaborFromTicket(ticketId, laborId);
        }

        // put request for updating all labors inside a ticket
        [HttpPut("updateLaborsOnTicket/{ticketId}")]
        public ActionResult UpdateLaborsOnTicket(int ticketId, [FromBody] List<TicketLabor> laborsFromBody)
        {
            return ((TicketsHandler)handler).HandleUpdateLaborOnTicket(ticketId, laborsFromBody);
        }

        // get request for searching tickets given a car number
        [HttpGet("searchTicketByCarNumber/{carNumber}")]
        public ActionResult SearchTicketByCarNumber(string carNumber)
        {
            return ((TicketsHandler)handler).SearchTicketByCarNumber(carNumber);
        }

        /* from here on down will be controllers that regards the labors */

        // post request for creating a labor
        [HttpPost("createLabor")]
        public ActionResult CreateLabor([FromBody] Labor labor)
        {
            return ((TicketsHandler)handler).HandleCreateLabor(labor);
        }

        // get request for retriving all labors
        [HttpGet("getLabors")]
        public ActionResult GetLabors()
        {
            return ((TicketsHandler)handler).HandleGetLabors();
        }

        // get request for retriving a specific labor by its id
        [HttpGet("getLabors/{id}")]
        public ActionResult GetLaborById(int id) 
        {
            return ((TicketsHandler)handler).HandleGetLaborById(id);
        }

        // put request for updating a specific labor
        [HttpPut("updateLaborByid/{id}")]
        public ActionResult UpdateLaborById(int id, [FromBody] Labor labor)
        {
            return ((TicketsHandler)handler).HandleUpdateLaborById(id, labor);
        }

        // delete request for deleting a specific labor 
        [HttpDelete("deleteLaborById/{id}")]
        public ActionResult DeleteLaborById(int id)
        {
            return ((TicketsHandler)handler).HandleDeleteLaborById(id);
        }

        // get request for searching a labor given parameters
        [HttpGet("searchLabor/{searchParameter}")]
        public ActionResult SearchLaborByParameter(string searchParameter)
        {
            return ((TicketsHandler)handler).HandleSearchByParameter(searchParameter);
        }

        // delete request for closing a ticket given a ticket id
        [HttpDelete("closeTicket/{ticketId}")]
        public ActionResult CloseTicketById(int ticketId)
        {
            return ((TicketsHandler)handler).HandleCloseTicketById(ticketId);

        }

        /* from here on down will be controllers that regards the offers */
        
        // post request for creating an offer
        [HttpPost("createOffer")]
        public ActionResult CreateNewOffer([FromBody] CreateNewTicketRequest request)
        {
            return ((TicketsHandler)handler).HandleCreateOffer(request);
        }

        // get request for searching an offer given a car number
        [HttpGet("searchOfferByCarNumber/{carNumber}")]
        public ActionResult SearchOfferByCarNumber(string carNumber)
        {
            return ((TicketsHandler)handler).SearchOfferByCarNumber(carNumber);
        }

        // put request for updating an offer and turning it to a working ticket
        [HttpPut("updateOfferToTicket/{ticketId}")]
        public ActionResult UpdateOfferToTicket(string ticketId)
        {
            return ((TicketsHandler)handler).UpdateOfferToTicket(int.Parse(ticketId));
        }
    }


   
}
