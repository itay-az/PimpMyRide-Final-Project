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
        

        

        public ActionResult HandleCreate(CreateNewTicketRequest request)
        {
            Ticket newTicket = new Ticket(request.carId,request.clientFullName,request.clientId,request.clientPhoneNumber,request.clientEmail,request.causeOfArrival);
            var car = Server.Server.context.Car.SingleOrDefault(car => car.carId == request.carId);
            var tickets = Server.Server.context.Ticket.SingleOrDefault(t => t.carId == request.carId && t.state == TicketType.IS_OPEN);

            if (car == null)
            {
                return ErrorHandler.onFailure("Car doesnt exist","Not found");
            }
            if (tickets != null)
            {
                return ErrorHandler.onFailure("There is an open ticket with the same details", "Error",409);
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
            Ticket newTicket = new Ticket(request.carId, request.clientFullName, request.clientId, request.clientPhoneNumber, request.clientEmail, request.causeOfArrival,TicketType.IS_OFFER);
            var client = Server.Server.context.Clients.SingleOrDefault(client => client.clientId == request.clientId);
            var car = Server.Server.context.Car.SingleOrDefault(car => car.carId == request.carId);
            var tickets = Server.Server.context.Ticket.SingleOrDefault(t => t.carId == request.carId && t.state == TicketType.IS_OFFER);
            if (client == null)
            {
                return ErrorHandler.onFailure("Client doesnt exist", "Not found");
            }
            if (car == null)
            {
                return ErrorHandler.onFailure("Car doesnt exist", "Not found");
            }
            if (tickets != null)
            {
                return new StatusCodeResult(StatusCodes.Status409Conflict);
            }

            Server.Server.context.Ticket.Add(newTicket);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleGet()
        {


            var ticket = Server.Server.context.Ticket.Include("parts").Include("labors").Where(t => t.state == TicketType.IS_OPEN);

            if (ticket == null)
            {
                return ErrorHandler.onFailure("No open tickets found", "Not found");
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
                return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
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
                return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
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
                state = ticket.state,
                dateTime = ticket.dateTime
            };  

            if (ticket == null)
            {
                return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
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
                return ErrorHandler.onFailure("Part doesnt exist", "Not found");
            }
            else if (existingPart.quantity < partFromBody.quantity)
            {
                return ErrorHandler.onFailure("Not enough part units", "Not found",500);
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
                    return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
                }

                if (ticket.parts.Where(e => e.partId.Equals(partFromBody.partId)).ToList().Count() > 0)
                {
                    return ErrorHandler.onFailure("Part already exist in this ticket, please update the amount needed", "Not found");
                }

                ticket.parts.Add(ticketPart);


                ticket.totalPartsDiscount = 0;
                ticket.totalPartsPrice = 0;
                foreach (TicketPart part in ticket.parts)
                {
                    ticket.totalPartsPrice += decimal.ToDouble(part.price);
                    ticket.totalPartsDiscount += decimal.ToDouble(part.GetTotalDiscount());
                }

                ticket.totalLaborPrice = 0;
                ticket.totalLaborDiscount = 0;
                foreach (TicketLabor labor in ticket.labors)
                {
                    ticket.totalLaborPrice += decimal.ToDouble(labor.price);
                    ticket.totalLaborDiscount += decimal.ToDouble(labor.GetTotalDiscount());
                }

                ticket.price = ticket.totalLaborPrice + ticket.totalPartsPrice - ticket.totalLaborDiscount - ticket.totalPartsDiscount;

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
                return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
            }

            var ticketPart = ticket.parts.SingleOrDefault(p => p.partId == partId);
            var storagePart = Server.Server.context.Part.SingleOrDefault(p => p.partId == partId);

            storagePart.quantity += ticketPart.quantity;

            ticket.parts.Remove(ticketPart);


            ticket.totalPartsDiscount = 0;
            ticket.totalPartsPrice = 0;
            foreach (TicketPart part in ticket.parts)
            {
                ticket.totalPartsPrice += decimal.ToDouble(part.price);
                ticket.totalPartsDiscount += decimal.ToDouble(part.GetTotalDiscount());
            }

            ticket.totalLaborPrice = 0;
            ticket.totalLaborDiscount = 0;
            foreach (TicketLabor labor in ticket.labors)
            {
                ticket.totalLaborPrice += decimal.ToDouble(labor.price);
                ticket.totalLaborDiscount += decimal.ToDouble(labor.GetTotalDiscount());
            }
            ticket.price = ticket.totalLaborPrice + ticket.totalPartsPrice - ticket.totalLaborDiscount - ticket.totalPartsDiscount;


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
                return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
            }

            for (int i = 0; i < ticket.parts.Count; i++)
            {
                if (ticket.parts[i].quantity != partFromBody[i].quantity)
                {
                    var partFromStorage = Server.Server.context.Part.SingleOrDefault(p => p.partId == partFromBody[i].partId);
                    if (partFromStorage.quantity < partFromBody[i].quantity || (partFromStorage.quantity - partFromBody[i].quantity) < 0)
                    {
                        return ErrorHandler.onFailure("Not enough part units", "Not found", 500);
                    }

                    decimal tmp = ticket.parts[i].quantity - partFromBody[i].quantity;

                    partFromStorage.quantity += tmp;
                    Server.Server.context.Part.Update(partFromStorage);
                }
                ticket.parts[i] = partFromBody[i];
            }

            ticket.parts = partFromBody;


            ticket.totalPartsDiscount = 0;
            ticket.totalPartsPrice = 0;
            foreach (TicketPart part in ticket.parts)
            {
                ticket.totalPartsPrice += decimal.ToDouble(part.price);
                ticket.totalPartsDiscount += decimal.ToDouble(part.GetTotalDiscount());
            }

            ticket.totalLaborPrice = 0;
            ticket.totalLaborDiscount = 0;
            foreach (TicketLabor labor in ticket.labors)
            {
                ticket.totalLaborPrice += decimal.ToDouble(labor.price);
                ticket.totalLaborDiscount += decimal.ToDouble(labor.GetTotalDiscount());
            }
            ticket.price = ticket.totalLaborPrice + ticket.totalPartsPrice - ticket.totalLaborDiscount - ticket.totalPartsDiscount;

            Server.Server.context.Ticket.Update(ticket);

            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleCreateLabor(Labor labor)
        {
            var labors = Server.Server.context.Labor;
            if(labors.SingleOrDefault(l => l.Id == labor.Id) != null)
            {
                return ErrorHandler.onFailure("Labor already exist in the cuurent ticket", "Error",409);
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
                return ErrorHandler.onFailure("No labors exist", "Not found");
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
                return ErrorHandler.onFailure("No labors exist", "Not found");
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
                return ErrorHandler.onFailure("No labors exist", "Not found");
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
                return ErrorHandler.onFailure("No labors exist", "Not found");
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
                return ErrorHandler.onFailure("No labors exist", "Not found");
            }


            var ticket = Server.Server.context.Ticket.Include("parts").Include("labors").SingleOrDefault(t => t.ticketId == ticketId);

            if (ticket == null)
            {
                return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
            }

            if (ticket.labors.Where(e => e.Id.Equals(LaborFromBody.Id)).ToList().Count() > 0)
            {
                return ErrorHandler.onFailure("Labor already exist in the current ticket", "Error",500);
            }

            ticket.labors.Add(LaborFromBody);

            ticket.totalPartsDiscount = 0;
            ticket.totalPartsPrice = 0;
            foreach (TicketPart part in ticket.parts)
            {
                ticket.totalPartsPrice += decimal.ToDouble(part.price);
                ticket.totalPartsDiscount += decimal.ToDouble(part.GetTotalDiscount());
            }

            ticket.totalLaborPrice = 0;
            ticket.totalLaborDiscount = 0;
            foreach (TicketLabor labor in ticket.labors)
            {
                ticket.totalLaborPrice += decimal.ToDouble(labor.price);
                ticket.totalLaborDiscount += decimal.ToDouble(labor.GetTotalDiscount());
            }

            ticket.price = ticket.totalLaborPrice + ticket.totalPartsPrice - ticket.totalLaborDiscount - ticket.totalPartsDiscount;

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
                return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
            }

            var labor = ticket.labors.SingleOrDefault(labor => labor.Id == laborId);

            if(labor == null)
            {
                return ErrorHandler.onFailure("Labor doesnt exist", "Not found");
            }
            ticket.price -= Decimal.ToDouble(labor.price);
            ticket.totalLaborPrice -= Decimal.ToDouble(labor.price);


            ticket.labors.Remove(labor);


            ticket.totalPartsDiscount = 0;
            ticket.totalPartsPrice = 0;
            foreach (TicketPart part in ticket.parts)
            {
                ticket.totalPartsPrice += decimal.ToDouble(part.price);
                ticket.totalPartsDiscount += decimal.ToDouble(part.GetTotalDiscount());
            }

            ticket.totalLaborPrice = 0;
            ticket.totalLaborDiscount = 0;
            foreach (TicketLabor laborInTicket in ticket.labors)
            {
                ticket.totalLaborPrice += decimal.ToDouble(labor.price);
                ticket.totalLaborDiscount += decimal.ToDouble(laborInTicket.GetTotalDiscount());
            }
            ticket.price = ticket.totalLaborPrice + ticket.totalPartsPrice - ticket.totalLaborDiscount - ticket.totalPartsDiscount;

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
                return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
            }


            ticket.labors = laborsFromBody;

            ticket.totalPartsDiscount = 0;
            ticket.totalPartsPrice = 0;
            foreach (TicketPart part in ticket.parts)
            {
                ticket.totalPartsPrice += decimal.ToDouble(part.price);
                ticket.totalPartsDiscount += decimal.ToDouble(part.GetTotalDiscount());
            }

            ticket.totalLaborPrice = 0;
            ticket.totalLaborDiscount = 0;
            foreach (TicketLabor labor in ticket.labors)
            {
                ticket.totalLaborPrice += decimal.ToDouble(labor.price);
                ticket.totalLaborDiscount += decimal.ToDouble(labor.GetTotalDiscount());
            }
            ticket.price = ticket.totalLaborPrice + ticket.totalPartsPrice - ticket.totalLaborDiscount - ticket.totalPartsDiscount;

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
                return ErrorHandler.onFailure("Labor doesnt exist", "Not found");
            }

            JsonResult jsonResult = new JsonResult(labors);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }


        public ActionResult SearchTicketByCarNumber(string carNumber)
        {
            if (carNumber == String.Empty)
            {
                return HandleGet();
            }

            var tickets = Server.Server.context.Ticket
                .Where(t => t.carId.Contains(carNumber) && t.state == TicketType.IS_OPEN)
                .ToList();

            if (tickets == null)
            {
                return ErrorHandler.onFailure("No open ticket found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(tickets);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        public ActionResult SearchOfferByCarNumber(string carNumber)
        {
            if (carNumber == String.Empty)
            {
                return HandleGet();
            }

            var tickets = Server.Server.context.Ticket
                .Where(t => t.carId.Contains(carNumber) && t.state == TicketType.IS_OFFER)
                .ToList();

            if (tickets == null || tickets.Count == 0)
            {
                return ErrorHandler.onFailure("No open offers found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(tickets);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }


        public ActionResult UpdateOfferToTicket(int ticketId)
        {
            var ticket = Server.Server.context.Ticket
                .SingleOrDefault(t => t.ticketId == ticketId && t.state == TicketType.IS_OFFER);

            if(ticket == null)
            {
                return ErrorHandler.onFailure("Ticket doesnt exist", "Not found");
            }

            ticket.state = TicketType.IS_OPEN;

            Server.Server.context.Ticket.Update(ticket);
            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);

        }

    }




}
