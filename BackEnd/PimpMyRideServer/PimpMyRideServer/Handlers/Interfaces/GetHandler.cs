using Microsoft.AspNetCore.Mvc;

namespace PimpMyRideServer.Handlers.Interfaces
{
    public interface GetHandler : Handler
    {
        public ActionResult HandleGet();
    }
}
