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
            jsonResult.Value = message;
            return jsonResult;
        }
        
        public ActionResult HandleCreate(CreateNewTicketRequest request)
        {
            Ticket newTicket = new Ticket(request.carId,request.clientFullName,request.clientId,request.clientPhoneNumber,request.clientEmail,request.causeOfArrival);
            var car = Server.Server.context.Car.SingleOrDefault(car => car.carId == request.carId);
            var tickets = Server.Server.context.Ticket.SingleOrDefault(t => t.carId == request.carId && t.state == TicketType.IS_OPEN);

            if (car == null)
            {
                return onFailure("Car doesnt exist");
            }
            if (tickets != null)
            {
                return new StatusCodeResult(StatusCodes.Status409Conflict);
            }


            car.carKilometer = request.carKilometer;
            Server.Server.context.SaveChanges();

            car.ticketIds.Add(newTicket.ticketId);
            Server.Server.context.Ticket.Add(newTicket);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleCreateOffer(CreateNewTicketRequest request)
        {
            Ticket newTicket = new Ticket(request.carId, request.clientId, request.causeOfArrival,TicketType.IS_OFFER);
            var client = Server.Server.context.Clients.SingleOrDefault(client => client.clientId == request.clientId);
            var car = Server.Server.context.Car.SingleOrDefault(car => car.carId == request.carId);
            var tickets = Server.Server.context.Ticket.SingleOrDefault(t => t.carId == request.carId);
            if (client == null)
            {
                return onFailure("Client doesnt exist");
            }
            if (car == null)
            {
                return onFailure("Car doesnt exist");
            }
            if (tickets != null)
            {
                return new StatusCodeResult(StatusCodes.Status409Conflict);
            }


            Server.Server.context.SaveChanges();

            Server.Server.context.Ticket.Add(newTicket);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleGet()
        {


            var ticket = Server.Server.context.Ticket.Include("parts").Include("labors").Where(t => t.state == TicketType.IS_OPEN);

            if (ticket == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResults = new JsonResult(ticket);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;


        }
   
        public ActionResult HandleDelete(int ticketId)
        {
            var ticket = Server.Server.context.Ticket.SingleOrDefault(ticket => ticket.ticketId == ticketId);

            if (ticket == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            Server.Server.context.Ticket.Remove(ticket);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleCloseTicketById(int ticketId)
        {
            var ticket = Server.Server.context.Ticket.SingleOrDefault(ticket => ticket.ticketId == ticketId);

            if (ticket == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            ticket.state = TicketType.IS_CLOSED;

            
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);

        }

        public ActionResult HandlGetById(int ticketId)
        {
            var ticket = Server.Server.context.Ticket.Include("parts").Include("labors").SingleOrDefault(ticket => ticket.ticketId == ticketId);
            var car = Server.Server.context.Car.SingleOrDefault(car => car.carId == ticket.carId);
            var client = Server.Server.context.Clients.SingleOrDefault(client => client.clientId == ticket.clientId);



            GetTicketByIdResponse response = new GetTicketByIdResponse
            {
                carId = ticket.carId,
                clientId = ticket.clientId,
                clientFullName = ticket.clientFullName,
                carManufacture = car.carManufacture,
                carModel = car.carModel,
                carEngine = car.carEngine,
                carYear = car.carYear,
                carKilometer = car.carKilometer,
                vinNumber = car.vinNumber,
                clientPhoneNumber = ticket.clientPhone,
                clientEmail = ticket.clientEmail,
                causeOfArrival = ticket.problems,
                parts = ticket.parts,
                labors = ticket.labors,
                totalPartsPrice = ticket.totalPartsPrice,
                totalPartsDiscount = ticket.totalPartsDiscount,
                totalLaborPrice = ticket.totalLaborPrice,
                totalLaborDiscount = ticket.totalLaborDiscount,
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

                ticket.calculatePartPrice();

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

            storagePart.quantity += ticketPart.quantity;

            ticket.parts.Remove(ticketPart);

            ticket.calculatePartPrice();
            ticket.calculate();
            

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
                    if (partFromStorage.quantity < partFromBody[i].quantity || (partFromStorage.quantity - partFromBody[i].quantity) < 0)
                    {
                        return onFailure("Not enough parts in storage");
                    }

                    decimal tmp = ticket.parts[i].quantity - partFromBody[i].quantity;

                    partFromStorage.quantity += tmp;
                    Server.Server.context.Part.Update(partFromStorage);
                }
                ticket.parts[i] = partFromBody[i];
            }

            ticket.parts = partFromBody;

            ticket.calculatePartPrice();
            ticket.calculate();

            Server.Server.context.Ticket.Update(ticket);

            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleCreateLabor(Labor labor)
        {
            var labors = Server.Server.context.Labor;
            if(labors.SingleOrDefault(l => l.Id == labor.Id) != null)
            {
                return onFailure("Labor already exist");
            }

            labors.Add(labor);

            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleGetLabors()
        {
            var labors = Server.Server.context.Labor.ToList();
            if(labors == null)
            {
                return onFailure("No labors found");
            }
            JsonResult jsonResult = new JsonResult(labors);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        public ActionResult HandleGetLaborById(int id)
        {
            var labor = Server.Server.context.Labor.SingleOrDefault(l => l.Id == id);
            if(labor == null)
            {
                return onFailure("Labor doesnt exist");
            }
            JsonResult jsonResult = new JsonResult(labor);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;

        }

        public ActionResult HandleUpdateLaborById(int id, Labor laborFromBody)
        {
            var existingLabor = Server.Server.context.Labor.SingleOrDefault(l => l.Id == id);
            if (existingLabor == null)
            {
                return onFailure("Labor doesnt exist");
            }

            existingLabor.time = laborFromBody.time;
            existingLabor.price = laborFromBody.price;
            existingLabor.description = laborFromBody.description;
            existingLabor.discount = laborFromBody.discount;

            Server.Server.context.Labor.Update(existingLabor);
            Server.Server.context.SaveChanges();

            JsonResult jsonResult = new JsonResult(existingLabor);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        public ActionResult HandleDeleteLaborById(int id)
        {
            var existingLabor = Server.Server.context.Labor.SingleOrDefault(l => l.Id == id);

            if (existingLabor == null)
            {
                return onFailure("Labor doesnt exist");
            }

            Server.Server.context.Labor.Remove(existingLabor);
            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);

        }

        public ActionResult HandleAddLaborToTicket(int ticketId, TicketLabor LaborFromBody)
        {
            var existingLabor = Server.Server.context.Labor.SingleOrDefault(l => l.Id == LaborFromBody.Id);

            if (existingLabor == null)
            {
                return onFailure("Labor doesnt exist");
            }


            var ticket = Server.Server.context.Ticket.Include("parts").Include("labors").SingleOrDefault(t => t.ticketId == ticketId);

            if (ticket == null)
            {
                return onFailure("Ticket doesnt exist");
            }

            if (ticket.labors.Where(e => e.Id.Equals(LaborFromBody.Id)).ToList().Count() > 0)
            {
                return onFailure("Labor already exist in the ticket");
            }

            ticket.labors.Add(LaborFromBody);

            ticket.calculateLaborPrice();
            ticket.calculate();


            Server.Server.context.Ticket.Update(ticket);

            Server.Server.context.SaveChanges();

            JsonResult jsonResults = new JsonResult(ticket);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;
        }

        public ActionResult HandleRemoveLaborFromTicket(int ticketId, int laborId)
        {
            var ticket = Server.Server.context.Ticket
                .Include("parts")
                .Include("labors")
                .SingleOrDefault(t => t.ticketId == ticketId);

            if (ticket == null)
            {
                return onFailure("Ticket not found");
            }

            var labor = ticket.labors.SingleOrDefault(labor => labor.Id == laborId);

            if(labor == null)
            {
                return onFailure("Labor not found");
            }
            ticket.price -= Decimal.ToDouble(labor.price);
            ticket.totalLaborPrice -= Decimal.ToDouble(labor.price);


            ticket.labors.Remove(labor);

            ticket.calculateLaborPrice();
            ticket.calculate();

            Server.Server.context.Ticket.Update(ticket);

            Server.Server.context.SaveChanges();

            JsonResult jsonResults = new JsonResult(ticket);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;
        }
        
        public ActionResult HandleUpdateLaborOnTicket(int ticketId, List<TicketLabor> laborsFromBody)
        {
            var ticket = Server.Server.context.Ticket.SingleOrDefault(t => t.ticketId == ticketId);

            if (ticket == null)
            {
                return onFailure("Ticket not found");
            }


            ticket.labors = laborsFromBody;

            ticket.calculateLaborPrice();
            ticket.calculate();

            Server.Server.context.Ticket.Update(ticket);

            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);
        } 

        public ActionResult HandleSearchByParameter(string searchParameter)
        {
            if (searchParameter == String.Empty)
            {
                return HandleGetLabors();
            }

            var labors = Server.Server.context.Labor
                .Where(l => l.description.Contains(searchParameter))
                .ToList();

            if (labors == null)
            {
                return onFailure("No parts found");
            }

            JsonResult jsonResult = new JsonResult(labors);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }
    }
}
