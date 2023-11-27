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

            var you = Server.Server.context.User.SingleOrDefault(u => u.UserName == loginRequest.UserName && u.Password == loginRequest.Password);


            if (you == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }
            return new OkObjectResult(you.JobTitle);


        }
    }
    }

