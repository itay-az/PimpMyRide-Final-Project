using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers.Interfaces;

namespace PimpMyRideServer.Controllers
{
    // creating a abstract class for the context 
    public abstract class GarageController : ControllerBase
    {
        // creating a handler prop for the abstract class so that every class that inherits will need to use a handler
        protected Handler handler;
    }
}
