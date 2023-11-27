using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.NewFolder;
using PimpMyRideServer.Server.Requests;
using PimpMyRideServer.Server.Responses;
using System.Linq;

namespace PimpMyRideServer.Handlers
{
    public class ClientHandler : CreateHandler, GetByIdHandler, GetHandler, DeleteHandler, PutHandler
    {
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

        public ActionResult HandleDelete(int id)
        {
            var user = Server.Server.context.User.SingleOrDefault(u => u.Id == id);

            if (user == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            Server.Server.context.User.Remove(user);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleGet()
        {

            var clients = Server.Server.context.Clients;


            if (clients == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }
            JsonResult jsonResult = new JsonResult(clients);
            jsonResult.StatusCode = StatusCodes.Status200OK;


            return jsonResult;
        }

        public ActionResult HandlGetById(string id)
        {
            var client = Server.Server.context.Clients.SingleOrDefault(c => c.clientId == id);

            if (client == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResult = new JsonResult(buildClientResponse(client));
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
            CreateClientRequest createClientRequest = request;

            var c = Server.Server.context.Clients.SingleOrDefault(u => u.clientId == createClientRequest.id);

            if (c == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }
            Client client = (Client)c;
            Car car = new Car(createClientRequest.carId, client.clientId, createClientRequest.carManufacture, createClientRequest.carModel,
                createClientRequest.carEngine, createClientRequest.carYear, createClientRequest.carKilometer, createClientRequest.vinNumber);
            client.cars.Add(car);
            Server.Server.context.Car.Add(car);
            Server.Server.context.Clients.Update(client);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);

        }

        public ActionResult AddCarToClient(CreateClientRequest request)
        {
            CreateClientRequest createClientRequest = (CreateClientRequest)request;

            var c = Server.Server.context.Clients.SingleOrDefault(u => u.clientId == createClientRequest.id);

            if (c == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            Client client = (Client)c;
            Car car = new Car(createClientRequest.carId, client.clientId, createClientRequest.carManufacture, createClientRequest.carModel,
                createClientRequest.carEngine, createClientRequest.carYear, createClientRequest.carKilometer, createClientRequest.vinNumber);
            client.cars.Add(car);
            Server.Server.context.Car.Add(car);
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

        public ActionResult HandleUpdate(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
