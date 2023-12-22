using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.NewFolder;
using PimpMyRideServer.Server.Requests;
using PimpMyRideServer.Server.Responses;

namespace PimpMyRideServer.Handlers
{

    // client handler that handles all the http requests regarding the clients
    public class ClientHandler : CreateHandler, GetByIdHandler, GetHandler
    {
        // function that handles the create http request, routing from the controller,
        // it recieves a create request, checks if the client doesnt already exist,
        // if everything checks out it creates a new client and returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleCreate(Request request)
        {
            CreateClientRequest createClientRequest = (CreateClientRequest)request;

            var c = Server.Server.context.Clients.SingleOrDefault(u => u.clientId == createClientRequest.id);

            if (c != null)
            {
                return ErrorHandler.onFailure("Client already exist", "Conflict",409);
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

        // function that handles the delete http request, routing from the controller,
        // it recieves an id, checks if the client exist,
        // if everything checks out it deletes the client and returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleDelete(string id)
        {
            var client = Server.Server.context.Clients.SingleOrDefault(c => c.clientId == id);

            if (client == null)
            {
                return ErrorHandler.onFailure("Client not found", "Not found");
            }

            Server.Server.context.Clients.Remove(client);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        // function that handles get all clients http request, routing from the controller,
        // checks if there is at least one client,
        // if everything checks out it returns all clients as json object with status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleGet()
        {

            var clients = Server.Server.context.Clients
                .ToList();

            if (clients == null || clients.Count() == 0)
            {
                return ErrorHandler.onFailure("Clients not found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(clients);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        // function that handles the get client by id http request, routing from the controller,
        // it recieves a string id, checks if the client exist,
        // if everything checks out it creates a new json object with all the details of the client and returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandlGetById(string id)
        {
            var client = Server.Server.context.Clients.Include("cars").SingleOrDefault(c => c.clientId == id);

            if (client == null)
            {
                return ErrorHandler.onFailure("Client not found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(client);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        // function that handles the get car by car number http request, routing from the controller,
        // it recieves a string id, checks if the car exist,
        // if everything checks out it creates a new json object with all the details of the car and returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult GetCarByCarId(string id)
        {
            var car = Server.Server.context.Car.SingleOrDefault(c => c.carId == id);

            if (car == null)
            {
                return ErrorHandler.onFailure("Client not found", "Not found");
            }

            var client = Server.Server.context.Clients.SingleOrDefault(c => c.clientId == car.clientId);

            ExtendedCarResponse extendedCarResponse = new ExtendedCarResponse(car.carId, car.carManufacture, car.carModel, car.carEngine, car.carYear, car.carKilometer, car.vinNumber, client.clientId, client.name, client.phone, client.email);
            
            JsonResult jsonResult = new JsonResult(extendedCarResponse);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        // function that handles the get client by car id http request, routing from the controller,
        // it recieves a string id, checks if the client exist,
        // if everything checks out it creates a new json object with all the details of the client and returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleGetClientByCarId(string id)
        {
            var car = Server.Server.context.Car.SingleOrDefault(c => c.carId == id);
            var client = Server.Server.context.Clients.SingleOrDefault(c => c.clientId == car.clientId);

            if (client == null)
            {
                return ErrorHandler.onFailure("Client not found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(buildClientResponse(client));
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        // function that handles the update client by id http request, routing from the controller,
        // it recieves a string id, checks if the client exist,
        // if everything checks out it returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleUpdate(CreateClientRequest request)
        {

            var client = Server.Server.context.Clients.Include("cars").SingleOrDefault(c => c.clientId == request.id);

            if (client == null)
            {
                return ErrorHandler.onFailure("Client not found", "Not found");
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

        // function that handles the add car to client by id http request, routing from the controller,
        // it recieves a string id, checks if the client exist,
        // if the client exists, it checks if the car exist, otherwise it returns a customized client not found object
        // if tha car does exists, it updates the client information on the car table
        // if everything checks out it creates a new json object with all the details of the client and returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleAddCarToClient(string clientId, AddCarToClientRequest request)
        {
            var client = Server.Server.context.Clients.Include("cars").SingleOrDefault(c => c.clientId == clientId);

            if (client == null)
            {
                return ErrorHandler.onFailure("Client not found", "Not found");
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

        // function that creates a customized response that contains multiple parameters from multiple entities inside the databse
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

        // function that handles the get car history by car number http request, routing from the controller,
        // it recieves a string car number, checks if the car exist,
        // if everything checks out it creates a new json object with all the neccesary information and returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleGetCarHistory(string carId)
        {
            var carHistoryTickets = Server.Server.context.Ticket.Where(t => t.carId == carId && t.state ==TicketType.IS_CLOSED).ToList();

            if(carHistoryTickets == null)
            {
                return ErrorHandler.onFailure("No history for this car", "Not found");
            }

            JsonResult jsonResult = new JsonResult(carHistoryTickets);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

    }
}
