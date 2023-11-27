using PimpMyRideServer.Models;
using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Server.Requests
{
    public class CreatePartRequest : Request
    {
        public string partId { get; set; }
        public string partName { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
        public List<Ticket> tickets { get; set; }


        public CreatePartRequest(string partId,string partName, decimal price, decimal quantity)
        {
            this.partId = partId;
            this.partName = partName;
            this.price = price;
            this.quantity = quantity;
            this.tickets = new List<Ticket>();
        }

    }
}
