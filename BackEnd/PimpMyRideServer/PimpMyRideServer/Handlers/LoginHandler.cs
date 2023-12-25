using PimpMyRideServer.Data;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;
using System;
using System.Net;
using PimpMyRideServer.Handlers.Interfaces;

namespace PimpMyRideServer.Handlers
{

    // login handler that handles all the login http requests regarding login
    public class LoginHandler : CreateHandler
    {
        // a function that recives a login request as a parameter
        // it checks if the user information provided matches the one on the database
        // if everything checks out it returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleCreate(Request request)
        {
            LoginRequest loginRequest = (LoginRequest)request;

            var user = Server.Server.context.User.SingleOrDefault(u => u.UserName == loginRequest.UserName && u.Password == loginRequest.Password);

            if (user == null)
            {
                return ErrorHandler.onFailure("User not found", "Not found");
            }

            return new OkObjectResult(user.JobTitle);


        }
    }
    }

