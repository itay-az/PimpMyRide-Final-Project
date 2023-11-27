using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Handlers.Interfaces
{
    public interface GetByUserNameHandler : Handler
    {
        public ActionResult HandleGetByUserName(string UserName);
    }
}
