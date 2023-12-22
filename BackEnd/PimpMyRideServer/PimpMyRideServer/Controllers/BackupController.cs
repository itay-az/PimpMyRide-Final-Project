using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;

namespace PimpMyRideServer.Controllers
{
    // base route controller for backup that inherits from GarageController
    [Route("/backup")]
    [ApiController]
    public class BackupController : GarageController
    {
        // asigning the handler to the backup handler within the constructor
        public BackupController()
        {
            this.handler = new BackupHandler();
        }

        // creating a get request for immiediate backup on request
        [HttpGet]
        public ActionResult PerformBackUp()
        {
            return ((BackupHandler)handler).PerformBackUp();
        }
    }
}
