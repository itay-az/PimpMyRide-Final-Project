using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Controllers
{
    // base route controller for login that inherits from GarageController
    [Route("/login")]
    [ApiController]
    public class LoginController : GarageController
    {
        // asigning the handler to the login handler within the constructor
        public LoginController() 
        {
            this.handler = new LoginHandler();
        }

        // post controller for signin in a user

        [HttpPost]
        public ActionResult Login([FromBody]LoginRequest request)
        {   
            return ((LoginHandler)handler).HandleCreate((Request)request);
        }

        
    }
}
