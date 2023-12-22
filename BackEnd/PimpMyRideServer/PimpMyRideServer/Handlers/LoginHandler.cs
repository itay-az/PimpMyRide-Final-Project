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

    public class LoginHandler : CreateHandler
    {

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

