using PimpMyRideServer.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Server.Requests
{
    public class AddCarToClientRequest : Request
    {
        [Key] public string carId { get; set; } = null!;
        [Required] public string clientId { get; set; }

        [Required] public string carManufacture { get; set; } = null!;
        [Required] public string carModel { get; set; } = null!;
        [Required] public string carEngine { get; set; } = null!;

        [Required] public int carYear { get; set; }

        [Required] public int carKilometer { get; set; }

        [Required] public string vinNumber { get; set; } = null!;
        public DateTime dateTime { get; set; }
        public List<int> ticketIds { get; set; } = new List<int>();
    }
}
