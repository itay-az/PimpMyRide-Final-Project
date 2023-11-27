using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Controllers
{
    [Route("/user")]
    [ApiController]
    public class UserController : GarageController
    {

        public UserController() 
        {
            this.handler = new UserHandler();
        }
        [HttpPost]
        public ActionResult CreateUser([FromBody] CreateUserRequset request)
        {
            return ((UserHandler)handler).HandleCreate(request);
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            return ((UserHandler)handler).HandleGet();
        }

     
        [HttpGet("{userName}")]
        public ActionResult GetUserByUserName(string userName)
        {
            return ((UserHandler)handler).HandleGetByUserName(userName);
        }

        [HttpDelete("{userId}")]
        public ActionResult DeleteUser(string userId)
        {
            int parsedId = int.Parse(userId);
            return ((UserHandler)handler).HandleDelete(parsedId);
        }


        [HttpPut("{userId}")]
        public ActionResult PutUser(string userId, [FromBody] PutUserRequest request)
        {
            int parsedId = int.Parse(userId);
            return ((UserHandler)handler).HandleUpdate(request);
        }

    }
}
