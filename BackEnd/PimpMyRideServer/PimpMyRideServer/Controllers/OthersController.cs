using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;

namespace PimpMyRideServer.Controllers
{
    // base route controller for backup that inherits from GarageController
    [Route("")]
    [ApiController]
    public class OthersController : GarageController
    {
        // asigning the handler inside the constructor
        public OthersController()
        {
            this.handler = new OthersHandler();
        }

        // creating a get request for immiediate backup on request
        [HttpGet("/backup")]
        public ActionResult PerformBackUp()
        {
            return ((OthersHandler)handler).PerformBackUp();
        }
        // creating a get request for monthly statistics
        [HttpGet("/statistics")]
        public ActionResult GetStatistics()
        {
            return ((OthersHandler)handler).GetStatistics();
        
        }

        // creating a get request for yearly statistics
        [HttpGet("statistics/yearly")]
        public ActionResult GetStatisticsYearly()
        {
            return ((OthersHandler)handler).GetStatisticsYearly();
        }
    }
}
