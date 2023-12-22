using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Server.Requests;
using PimpMyRideServer.Models;

namespace PimpMyRideServer.Controllers
{
    // base route controller for clients that inherits from GarageController
    [Route("/client")]
    [ApiController]
    public class ClientController : GarageController
    {
        // asigning the handler to the client handler within the constructor

        public ClientController()
        {
            this.handler = new ClientHandler();
        }

        // post controller for creating a new client
        [HttpPost]
        public ActionResult CreateClient([FromBody] CreateClientRequest request)
        {
            return ((ClientHandler)handler).HandleCreate(request);
        }

        // get function for retrieving all clients
        [HttpGet]
        public ActionResult GetAllClients()
        {
            return ((ClientHandler)handler).HandleGet();
        }

        // get function for retrieving specific client given an id within the url
        [HttpGet("getClientByClientId/{clientId}")]
        public ActionResult GetClientById(string clientId)
        {
            return ((ClientHandler)handler).HandlGetById(clientId);
        }

        // get function for retrieving specific client given an car numer within the url
        [HttpGet("getClientByCarId/{carId}")]
        public ActionResult GetClientByCarNum(string carId)
        {
            return ((ClientHandler)handler).HandleGetClientByCarId(carId);
        }

        // get function for retrieving specific car given an car numer within the url
        [HttpGet("getCarByCarId/{carId}")]
        public ActionResult GetCarByCarId(string carId)
        {
            return ((ClientHandler)handler).GetCarByCarId(carId);
        }

        // delete function for deleting client given a client id within the url
        [HttpDelete("{clientId}")]
        public ActionResult DeleteClient(string clientId)
        {
            return ((ClientHandler)handler).HandleDelete(clientId);
        }

        // put function for updating client given the client id within the url and an updated body that contains the updated client information
        [HttpPut("{clientId}")]
        public ActionResult UpdateClient(string clientId, [FromBody] CreateClientRequest request)
        {
            return ((ClientHandler)handler).HandleUpdate(request);
        }

        // put function for adding a car from the body of the request to a specific client given a client id within the url
        [HttpPut("client/addCar/{clientId}")]
        public ActionResult AddCarToClient(string clientId, [FromBody] AddCarToClientRequest car)
        {
            return ((ClientHandler)handler).HandleAddCarToClient(clientId, car);
        }

        // get function for retreiving the car history given the car number within the url
        [HttpGet("getHistory/{carId}")]
        public ActionResult GetCarHistory(string carId)
        {
            return ((ClientHandler)handler).HandleGetCarHistory(carId);
        }
    }
}
