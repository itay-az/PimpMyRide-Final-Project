using PimpMyRideServer.Models;
using PimpMyRideServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;
using PimpMyRideServer.Handlers.Interfaces;

namespace PimpMyRideServer.Handlers
{
    public class SearchCarHandler : Handler
    {/*
        public HttpListenerContext Handle(HttpListenerContext ctx)
        {
            using (StreamReader reader = new StreamReader(ctx.Request.InputStream))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Received POST content: " + content);
                User user = JsonConvert.DeserializeObject<User>(content);

                /*var you = Listener.context.User.SingleOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);

                if (you == null)
                {
                    ctx.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    ctx.Response.StatusDescription = HttpStatusCode.NotFound.ToString();
                
                return ctx;
            }

    
        }*/
        public ActionResult Handle(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
