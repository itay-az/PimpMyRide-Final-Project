using PimpMyRideServer.Models;
using System.IO;

namespace PimpMyRideServer.Server.Requests
{
    public class CreateNewOrderRequest :Request
    {
        public List<OrderPart> parts { get; set; }
        public string supplierName { get; set; }

        public double price { get; set; }

    }
}
