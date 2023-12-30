using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Handlers.Interfaces
{
    // an interface for handling any Get by user names requests
    public interface GetByUserNameHandler : Handler
    {
        // the defining of the handling request
        public ActionResult HandleGetByUserName(string UserName);
    }
}
