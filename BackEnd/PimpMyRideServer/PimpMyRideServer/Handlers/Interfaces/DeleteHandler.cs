using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Handlers.Interfaces
{
    public interface DeleteHandler : Handler
    {
        public ActionResult HandleDelete(int id);
    }
}
