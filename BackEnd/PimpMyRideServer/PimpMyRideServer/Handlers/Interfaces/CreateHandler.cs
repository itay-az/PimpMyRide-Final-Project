using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Handlers.Interfaces
{
    // an interface for handling any create requests
    public interface CreateHandler : Handler
    {
        // the defining of the handling request
        public ActionResult HandleCreate(Request request);
    }
}
