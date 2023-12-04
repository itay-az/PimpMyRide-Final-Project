﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.NewFolder;
using PimpMyRideServer.Server.Requests;
using PimpMyRideServer.Server.Responses;

namespace PimpMyRideServer.Handlers
{
    public class ClientHandler : CreateHandler, GetByIdHandler, GetHandler
    {
        private ActionResult onFailure(string message, string errorCode, int statusCode = StatusCodes.Status404NotFound, string details = null, List<ValidationError> validationErrors = null)
        {
            var errorResponse = new ErrorResponse
            {
                Success = false,
                Message = message,
                StatusCode = statusCode,
                ErrorCode = errorCode,
                Details = details,
                ValidationErrors = validationErrors
            };

            JsonResult jsonResult = new JsonResult(errorResponse);
            jsonResult.StatusCode = statusCode;

            return jsonResult;
        }
        public ActionResult HandleCreate(Request request)
        {
            CreateClientRequest createClientRequest = (CreateClientRequest)request;

            var c = Server.Server.context.Clients.SingleOrDefault(u => u.clientId == createClientRequest.id);

            if (c != null)
            {
                return new StatusCodeResult(StatusCodes.Status409Conflict);
            }

            Client client = new Client(createClientRequest.id, createClientRequest.name, createClientRequest.phone, createClientRequest.email, createClientRequest.address,new List<Car>());
            Car car = new Car(createClientRequest.carId, client.clientId, createClientRequest.carManufacture, createClientRequest.carModel,
                createClientRequest.carEngine, createClientRequest.carYear, createClientRequest.carKilometer, createClientRequest.vinNumber);
            client.cars.Add(car);
            Server.Server.context.Car.Add(car);
            Server.Server.context.Clients.Add(client);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);

        }

        public ActionResult HandleDelete(string id)
        {
            var client = Server.Server.context.Clients.SingleOrDefault(c => c.clientId == id);

            if (client == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            Server.Server.context.Clients.Remove(client);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleGet()
        {

            var clients = Server.Server.context.Clients
                .ToList();

            if (clients.IsNullOrEmpty())
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResult = new JsonResult(clients);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        public ActionResult HandlGetById(string id)
        {
            var client = Server.Server.context.Clients.Include("cars").SingleOrDefault(c => c.clientId == id);

            if (client == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResult = new JsonResult(client);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        public ActionResult GetCarByCarId(string id)
        {
            var car = Server.Server.context.Car.SingleOrDefault(c => c.carId == id);

            if (car == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            var client = Server.Server.context.Clients.SingleOrDefault(c => c.clientId == car.clientId);

            ExtendedCarResponse extendedCarResponse = new ExtendedCarResponse(car.carId, car.carManufacture, car.carModel, car.carEngine, car.carYear, car.carKilometer, car.vinNumber, client.clientId, client.name, client.phone, client.email);
            
            JsonResult jsonResult = new JsonResult(extendedCarResponse);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        public ActionResult HandleGetClientByCarId(string id)
        {
            var car = Server.Server.context.Car.SingleOrDefault(c => c.carId == id);
            var client = Server.Server.context.Clients.SingleOrDefault(c => c.clientId == car.clientId);

            if (client == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResult = new JsonResult(buildClientResponse(client));
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        public ActionResult HandleUpdate(CreateClientRequest request)
        {

            var client = Server.Server.context.Clients.Include("cars").SingleOrDefault(c => c.clientId == request.id);

            if (client == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            var car = client.cars.SingleOrDefault(c => c.carId == request.carId);

            if (car == null)
            {
                client.name = request.name;

                client.email = request.email;
                client.phone = request.phone;
                client.address = request.address;

                Car newCar = new Car(request.carId, client.clientId, request.carManufacture, request.carModel,
                    request.carEngine, request.carYear, request.carKilometer, request.vinNumber);

                client.cars.Add(newCar);
                Server.Server.context.Clients.Update(client);
                Server.Server.context.SaveChanges();
                return new StatusCodeResult(StatusCodes.Status200OK);
            }
            else
            {
                client.name = request.name;
                client.email = request.email;
                client.phone = request.phone;
                client.address = request.address;

                Server.Server.context.Clients.Update(client);
                Server.Server.context.SaveChanges();
                return new StatusCodeResult(StatusCodes.Status200OK);
            }
            

        }

        public ActionResult HandleAddCarToClient(string clientId, AddCarToClientRequest request)
        {
            var client = Server.Server.context.Clients.Include("cars").SingleOrDefault(c => c.clientId == clientId);

            if (client == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            var existingCar = Server.Server.context.Car.SingleOrDefault(c => c.carId == request.carId);

            if(existingCar != null)
            {
                existingCar.Client = client;

                Server.Server.context.Car.Update(existingCar);
                Server.Server.context.SaveChanges();

                return new StatusCodeResult(StatusCodes.Status200OK);
            }

            Car car = new Car(request.carId, request.clientId, request.carManufacture, request.carModel, request.carEngine, request.carYear, request.carKilometer, request.vinNumber);

            client.cars.Add(car);
            Server.Server.context.Clients.Update(client);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);

        }

        private ClientResponse buildClientResponse(Client client) 
        {
            var carsFromDB = Server.Server.context.Car.Where(car => car.clientId == client.clientId).ToList();

            List<CarResponse> cars = new List<CarResponse>();
            foreach(Car car in carsFromDB)
            {
                cars.Add(new CarResponse(car.carId, car.carManufacture, car.carModel, car.carEngine, car.carYear, car.carKilometer, car.vinNumber));
            }
            return new ClientResponse(client.clientId, client.name, client.phone, client.email, client.address, cars);

        }

        public ActionResult HandleGetCarHistory(string carId)
        {
            var carHistoryTickets = Server.Server.context.Ticket.Where(t => t.carId == carId && t.state ==TicketType.IS_CLOSED).ToList();

            if(carHistoryTickets == null)
            {
                return onFailure("No history for this car", "Not found");
            }

            JsonResult jsonResult = new JsonResult(carHistoryTickets);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

    }
}
