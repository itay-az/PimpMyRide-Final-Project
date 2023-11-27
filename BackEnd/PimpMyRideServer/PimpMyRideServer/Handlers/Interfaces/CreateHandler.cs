using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Handlers.Interfaces
{
    public interface CreateHandler : Handler
    {
        public ActionResult HandleCreate(Request request);
    }
}
