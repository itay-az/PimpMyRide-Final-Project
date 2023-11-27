using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using PimpMyRideServer.Data;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;
using PimpMyRideServer.Server.Responses;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;
using EF = Microsoft.EntityFrameworkCore;

namespace PimpMyRideServer.Handlers
{
    public class TicketsHandler : Handler, GetHandler
    {
        private ActionResult onFailure(string message)
        {
            FailureResponse failureResponse = new FailureResponse
            {
                status = false,
                message = message
            };

            JsonResult jsonResult = new JsonResult(failureResponse);
            jsonResult.StatusCode = StatusCodes.Status404NotFound;
            return jsonResult;
        }
        
        public ActionResult HandleCreate(CreateNewTicketRequest request)
        {
            Ticket newTicket = new Ticket(request.carId,request.clientId,request.causeOfArrival);
            var client = Server.Server.context.Clients.SingleOrDefault(client => client.clientId == request.clientId);
            var car = Server.Server.context.Car.SingleOrDefault(car => car.carId == request.carId);
            var tickets = Server.Server.context.Ticket.SingleOrDefault(t => t.carId == request.carId);
            if (client == null )
            {
                FailureResponse failureResponse = new FailureResponse { status = false, message = "Client doesnt exist" };
                JsonResult jsonResults = new JsonResult(failureResponse);
                jsonResults.StatusCode = StatusCodes.Status404NotFound;
                return jsonResults;
            }
            if (car == null)
            {
                FailureResponse failureResponse = new FailureResponse { status = false, message = "Car doesnt exist" };
                JsonResult jsonResults = new JsonResult(failureResponse);
                jsonResults.StatusCode = StatusCodes.Status404NotFound;
                return jsonResults;
            }
            if (tickets != null)
            {
                return new StatusCodeResult(StatusCodes.Status409Conflict);
            }


            car.carKilometer = request.carKilometer;
            Server.Server.context.SaveChanges();


            Server.Server.context.Ticket.Add(newTicket);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleGet()
        {


            var ticket = Server.Server.context.Ticket.Include("parts");
            if (ticket == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResults = new JsonResult(ticket);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;


        }
        /*
        public TicketWithPartResponse GetTicketWithPartResponse(Ticket t)
        {
            List<PartResponse> partResponse = new List<PartResponse>();
            foreach (Part part in t.parts)
            {
                partResponse.Add(new PartResponse
                {
                    partId = part.partId,
                    partName = part.partName,
                    price = part.price,
                    quantity = part.quantity
                });
            }
            TicketWithPartResponse response = new TicketWithPartResponse
            {

                ticketId = t.ticketId,
                carId = t.carId,
                clientId = t.clientId,
                problems = t.problems,
                parts = partResponse,
                labors = t.labors,
                dateTime = t.dateTime,
                price = t.price
            };
            return response;
        }
        */
        public ActionResult HandleDelete(int ticketId)
        {
            var ticket = Server.Server.context.Ticket.SingleOrDefault(ticket => ticket.ticketId == ticketId);
            if (ticket == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            ticket.isOpen = false;

            Server.Server.context.Ticket.Remove(ticket);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandlGetById(int ticketId)
        {
            var ticket = Server.Server.context.Ticket.Include("parts").SingleOrDefault(ticket => ticket.ticketId == ticketId);
            var car = Server.Server.context.Car.SingleOrDefault(car => car.carId == ticket.carId);
            var client = Server.Server.context.Clients.SingleOrDefault(client => client.clientId == ticket.clientId);



            GetTicketByIdResponse response = new GetTicketByIdResponse
            {
                carId = ticket.carId,
                clientId = ticket.clientId,
                clientFullName = client.name,
                carManufacture = car.carManufacture,
                carModel = car.carModel,
                carEngine = car.carEngine,
                carYear = car.carYear,
                carKilometer = car.carKilometer,
                vinNumber = car.vinNumber,
                clientPhoneNumber = client.phone,
                clientEmail = client.email,
                causeOfArrival = ticket.problems,
                parts = ticket.parts,
                labors = ticket.labors,
                totalPartsPrice = ticket.totalPartsPrice,
                totalPartsDiscount = ticket.totalPartsDiscount,
                totalLaborPrice = ticket.totalLaborPrice,
                price = ticket.price,
            };  

            if (ticket == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResults = new JsonResult(response);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;

        }

        public ActionResult HandleAddPartToTicket(int ticketId, TicketPart partFromBody)
        {
            bool isAvailable = false;

            var existingPart = Server.Server.context.Part.SingleOrDefault(p => p.partId == partFromBody.partId);

            if (existingPart == null)
            {
                return onFailure("Part doesnt exist");
            }
            else if (existingPart.quantity < partFromBody.quantity)
            {
                return onFailure("Quantity requested is higher than current quantity");
            }

            existingPart.quantity -= partFromBody.quantity;

            Server.Server.context.Part.Update(existingPart);
            Server.Server.context.SaveChanges();

            isAvailable = true;

            if (isAvailable)
            {
                TicketPart ticketPart = new TicketPart
                {
                    partId = partFromBody.partId,
                    quantity = partFromBody.quantity,
                    partName = partFromBody.partName,
                    price = partFromBody.price,
                    unitPrice = partFromBody.unitPrice,
                };

                var ticket = Server.Server.context.Ticket.Include("parts").SingleOrDefault(t => t.ticketId == ticketId);
                if (ticket == null)
                {
                    return onFailure("Ticket doesnt exist");
                }

                if (ticket.parts.Where(e => e.partId.Equals(partFromBody.partId)).ToList().Count() > 0)
                {
                    return onFailure("Part already exist in the ticket");
                }
                ticket.parts.Add(ticketPart);

                ticket.totalPartsPrice += Decimal.ToDouble(ticketPart.price);
                ticket.calculate();


                Server.Server.context.Ticket.Update(ticket);

                Server.Server.context.SaveChanges();

                JsonResult jsonResults = new JsonResult(ticket);
                jsonResults.StatusCode = StatusCodes.Status200OK;
                return jsonResults;

            }
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }


        public ActionResult RemovePartFromTicket(int ticketId, string partId)
        {

            var ticket = Server.Server.context.Ticket
                .Include("parts")
                .SingleOrDefault(t => t.ticketId == ticketId);

            if (ticket == null)
            {
                return onFailure("Ticket not found");
            }

            var ticketPart = ticket.parts.SingleOrDefault(p => p.partId == partId);

            var storagePart = Server.Server.context.Part.SingleOrDefault(p => p.partId == partId);

            ticket.price -= Decimal.ToDouble(ticketPart.price);
            ticket.totalPartsPrice -= Decimal.ToDouble(ticketPart.price);

            

            storagePart.quantity += ticketPart.quantity;

            ticket.parts.Remove(ticketPart);

            

            Server.Server.context.Part.Update(storagePart);
            Server.Server.context.Ticket.Update(ticket);

            Server.Server.context.SaveChanges();

            JsonResult jsonResults = new JsonResult(ticket);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;


        }

        public ActionResult HandleUpdatePartsOnTicket(int ticketId, List<TicketPart> partFromBody) 
        {
            var ticket = Server.Server.context.Ticket.SingleOrDefault(t => t.ticketId == ticketId);



            if (ticket == null)
            {
                return onFailure("Ticket not found");
            }

            for(int i = 0; i < ticket.parts.Count; i++)
            {
                if (ticket.parts[i].quantity != partFromBody[i].quantity)
                {
                    var partFromStorage = Server.Server.context.Part.SingleOrDefault(p => p.partId == partFromBody[i].partId);

                    decimal tmp = ticket.parts[i].quantity - partFromBody[i].quantity;

                    partFromStorage.quantity += tmp;
                    Server.Server.context.Part.Update(partFromStorage);
                }
                ticket.parts[i] = partFromBody[i];
            }

            ticket.parts = partFromBody;

            Server.Server.context.Ticket.Update(ticket);

            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);
        }
    }
}
