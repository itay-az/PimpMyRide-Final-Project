using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Handlers.Interfaces
{
    public interface PutHandler : Handler
    {
        public ActionResult HandleUpdate(Request request);
    }
}
