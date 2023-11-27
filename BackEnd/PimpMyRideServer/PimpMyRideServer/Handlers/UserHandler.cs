using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Server.Requests;
using System.Net;

namespace PimpMyRideServer.Handlers
{

    public class UserHandler : CreateHandler, GetByUserNameHandler, GetHandler, DeleteHandler, PutHandler
    {
        public ActionResult HandleCreate(Request request)
        {
            CreateUserRequset createUserRequest = (CreateUserRequset)request;
            var you = Server.Server.context.User.SingleOrDefault(u => u.UserName == createUserRequest.UserName && u.Password == createUserRequest.Password && u.Email == createUserRequest.Email);

            if(you != null )
            {
                return new StatusCodeResult(StatusCodes.Status409Conflict);
            }
            Console.WriteLine();

            Server.Server.context.User.Add(createUserRequest);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);


        }

        public ActionResult HandleDelete(int id)
        {
            var user = Server.Server.context.User.SingleOrDefault(u => u.Id == id);

            if(user == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            Server.Server.context.User.Remove(user);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleGet()
        {
            var users = Server.Server.context.User;


            if (users == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }
            JsonResult jsonResult = new JsonResult(users);
            jsonResult.StatusCode = StatusCodes.Status200OK;


            return jsonResult;

        }

        public ActionResult HandleGetByUserName(string userName)
        {
            var user = Server.Server.context.User.SingleOrDefault(u => u.UserName == userName);


            if (user == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }
            JsonResult jsonResult = new JsonResult(user);
            jsonResult.StatusCode = StatusCodes.Status200OK;

            return jsonResult;
        }

        public ActionResult HandleUpdate(PutUserRequest request)
        {
            var user = Server.Server.context.User.SingleOrDefault(u => u.Id == request.Id);
            if (user == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            user.UserName = request.UserName;
            user.Password = request.Password;
            user.Email = request.Email;
            user.JobTitle = request.JobTitle;
            Server.Server.context.SaveChanges();



            return new StatusCodeResult(StatusCodes.Status200OK);

        }

        public ActionResult HandleUpdate(Request request)
        {
            throw new NotImplementedException();
        }
    }
    
}
