using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Handlers.Interfaces
{
    // an interface for handling any delete requests
    public interface DeleteHandler : Handler
    {
        // the defining of the handling request
        public ActionResult HandleDelete(int id);
    }
}
