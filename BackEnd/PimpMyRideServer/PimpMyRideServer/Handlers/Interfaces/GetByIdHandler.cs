using Microsoft.AspNetCore.Mvc;

namespace PimpMyRideServer.Handlers.Interfaces
{
    // an interface for handling any Get by ids requests
    public interface GetByIdHandler
    {
        // the defining of the handling request
        public ActionResult HandlGetById(string id);

    }
}
