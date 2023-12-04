using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Server.Requests;
using PimpMyRideServer.Models;

namespace PimpMyRideServer.Controllers
{
    [Route("/client")]
    [ApiController]
    public class ClientController : GarageController
    {

        public ClientController()
        {
            this.handler = new ClientHandler();
        }

        [HttpPost]
        public ActionResult CreateClient([FromBody] CreateClientRequest request)
        {
            return ((ClientHandler)handler).HandleCreate(request);
        }

        [HttpGet]
        public ActionResult GetAllClients()
        {
            return ((ClientHandler)handler).HandleGet();
        }


        [HttpGet("getClientByClientId/{clientId}")]
        public ActionResult GetClientById(string clientId)
        {
            return ((ClientHandler)handler).HandlGetById(clientId);
        }

        [HttpGet("getClientByCarId/{carId}")]
        public ActionResult GetClientByCarNum(string carId)
        {
            return ((ClientHandler)handler).HandleGetClientByCarId(carId);
        }
        [HttpGet("getCarByCarId/{carId}")]
        public ActionResult GetCarByCarId(string carId)
        {
            return ((ClientHandler)handler).GetCarByCarId(carId);
        }

        [HttpDelete("{clientId}")]
        public ActionResult DeleteClient(string clientId)
        {
            return ((ClientHandler)handler).HandleDelete(clientId);
        }


        [HttpPut("{clientId}")]
        public ActionResult UpdateClient(string clientId, [FromBody] CreateClientRequest request)
        {
            return ((ClientHandler)handler).HandleUpdate(request);
        }

        [HttpPut("client/addCar/{clientId}")]
        public ActionResult AddCarToClient(string clientId, [FromBody] AddCarToClientRequest car)
        {
            return ((ClientHandler)handler).HandleAddCarToClient(clientId, car);
        }
        [HttpGet("getHistory/{carId}")]
        public ActionResult GetCarHistory(string carId)
        {
            return ((ClientHandler)handler).HandleGetCarHistory(carId);
        }
    }
}
