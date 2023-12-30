using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Controllers
{
    // base route controller for users that inherits from GarageController
    [Route("/user")]
    [ApiController]
    public class UserController : GarageController
    {
        // asigning the handler to the client handler within the constructor
        public UserController() 
        {
            this.handler = new UserHandler();
        }

        // post request for creating a new user
        [HttpPost]
        public ActionResult CreateUser([FromBody] CreateUserRequset request)
        {
            return ((UserHandler)handler).HandleCreate(request);
        }

        // get request for retriving all users
        [HttpGet]
        public ActionResult GetAllUsers()
        {
            return ((UserHandler)handler).HandleGet();
        }

        // get request for retriving a specific user given its user name
        [HttpGet("{userName}")]
        public ActionResult GetUserByUserName(string userName)
        {
            return ((UserHandler)handler).HandleGetByUserName(userName);
        }

        // delete request for deleting a specific user
        [HttpDelete("{userId}")]
        public ActionResult DeleteUser(string userId)
        {
            int parsedId = int.Parse(userId);
            return ((UserHandler)handler).HandleDelete(parsedId);
        }

        // put request for updating a user
        [HttpPut("{userId}")]
        public ActionResult PutUser(string userId, [FromBody] PutUserRequest request)
        {
            int parsedId = int.Parse(userId);
            return ((UserHandler)handler).HandleUpdate(request);
        }

    }
}
