using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Handlers.Interfaces
{
    // an interface for handling any put requests
    public interface PutHandler : Handler
    {
        // the defining of the handling request
        public ActionResult HandleUpdate(Request request);
    }
}
