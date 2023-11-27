using Microsoft.AspNetCore.Mvc;

namespace PimpMyRideServer.Handlers.Interfaces
{
    public interface GetByIdHandler
    {
        public ActionResult HandlGetById(string id);

    }
}
