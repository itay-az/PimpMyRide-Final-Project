using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Server.Requests;
using System.Net;

namespace PimpMyRideServer.Handlers
{

    public class UserHandler : CreateHandler, GetByUserNameHandler, GetHandler, DeleteHandler, PutHandler
    {

        // function that handles the post http request, routing from the controller,
        // it recieves a request as a parameter
        // if everything checks out it creates the requested entity
        // otherwise it returns a customized failure response
        public ActionResult HandleCreate(Request request)
        {
            CreateUserRequset createUserRequest = (CreateUserRequset)request;
            var you = Server.Server.context.User.SingleOrDefault(u => u.UserName == createUserRequest.UserName && u.Password == createUserRequest.Password && u.Email == createUserRequest.Email);

            if(you != null )
            {
                return ErrorHandler.onFailure("User already exist", "Conflict",409);
            }
            Console.WriteLine();

            Server.Server.context.User.Add(createUserRequest);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);


        }

        // function that handles the delete http request, routing from the controller,
        // it recieves an id as a parameter
        // if everything checks out it deletes the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleDelete(int id)
        {
            var user = Server.Server.context.User.SingleOrDefault(u => u.Id == id);

            if(user == null)
            {
                return ErrorHandler.onFailure("User not found", "Not found");
            }

            Server.Server.context.User.Remove(user);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        // function that handles the get http request, routing from the controller,
        // if everything checks out it retrives the requested entity
        // otherwise it returns a customized failure response
        public ActionResult HandleGet()
        {
            var users = Server.Server.context.User;


            if (users == null)
            {
                return ErrorHandler.onFailure("Users not found", "Not found");
            }
            JsonResult jsonResult = new JsonResult(users);
            jsonResult.StatusCode = StatusCodes.Status200OK;


            return jsonResult;

        }

        // function that handles the get http request, routing from the controller,
        // it recieves an id as a parameter
        // if everything checks out it retrives the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleGetByUserName(string userName)
        {
            var user = Server.Server.context.User.SingleOrDefault(u => u.UserName == userName);


            if (user == null)
            {
                return ErrorHandler.onFailure("User not found", "Not found");
            }
            JsonResult jsonResult = new JsonResult(user);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        // function that handles the put http request, routing from the controller,
        // it recieves a request as a parameter
        // if everything checks out it updates the requested entity
        // otherwise it returns a customized failure response
        public ActionResult HandleUpdate(Request iRequest)
        {
            PutUserRequest request = iRequest as PutUserRequest;
            if (request == null)
            {
                return ErrorHandler.onFailure("Request not valid", "Bad Request",400);
            }
            var user = Server.Server.context.User.SingleOrDefault(u => u.Id == request.Id);
            if (user == null)
            {
                return ErrorHandler.onFailure("User not found", "Not found");
            }

            user.UserName = request.UserName;
            user.Password = request.Password;
            user.Email = request.Email;
            user.JobTitle = request.JobTitle;

            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);

        }

    }
    
}
