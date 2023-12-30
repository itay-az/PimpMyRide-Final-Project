using Microsoft.AspNetCore.Mvc;

namespace PimpMyRideServer.Handlers.Interfaces
{
    // an interface for handling any get requests
    public interface GetHandler : Handler
    {
        // the defining of the handling request
        public ActionResult HandleGet();
    }
}
