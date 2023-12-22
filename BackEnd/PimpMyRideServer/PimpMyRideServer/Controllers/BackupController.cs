using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;

namespace PimpMyRideServer.Controllers
{
    [Route("/backup")]
    [ApiController]
    public class BackupController : GarageController
    {
        public BackupController()
        {
            this.handler = new BackupHandler();
        }


        [HttpGet]
        public ActionResult PerformBackUp()
        {
            return ((BackupHandler)handler).PerformBackUp();
        }
    }
}
