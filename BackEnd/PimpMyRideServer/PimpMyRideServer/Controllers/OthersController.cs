using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;

namespace PimpMyRideServer.Controllers
{
    // base route controller for backup that inherits from GarageController
    [Route("")]
    [ApiController]
    public class OthersController : GarageController
    {
        // asigning the handler to the backup handler within the constructor
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
        [HttpGet("/statistics")]
        public ActionResult GetStatistics()
        {
            return ((OthersHandler)handler).GetStatistics();
        
        }

        [HttpGet("statistics/yearly")]
        public ActionResult GetStatisticsYearly()
        {
            return ((OthersHandler)handler).GetStatisticsYearly();
        }
    }
}
