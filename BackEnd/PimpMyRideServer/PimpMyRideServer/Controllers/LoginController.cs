using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Controllers
{
    [Route("/login")]
    [ApiController]
    public class LoginController : GarageController
    {

        public LoginController() 
        {
            this.handler = new LoginHandler();
        }

        [HttpPost]
        public ActionResult Login([FromBody]LoginRequest request)
        {
            
            return ((LoginHandler)handler).HandleCreate((Request)request);
        }

        [HttpGet]
        public async Task<ActionResult<LoginRequest>> LoginGet()
        {
            Console.WriteLine();
            LoginRequest test = new LoginRequest();
            test.UserName ="itay";
            test.Password= "123456";

            return Ok(test);
        }

        
    }
}
