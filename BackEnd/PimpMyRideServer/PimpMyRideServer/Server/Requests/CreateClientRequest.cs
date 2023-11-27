using PimpMyRideServer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Server.Requests
{
    public class CreateClientRequest : Request
    {
        [Required] public string id { get; set; } = null!;
        [Required] public string name { get; set; } = null!;

        [Required] public string phone { get; set; } = null!;
        public string? email { get; set; }
        public string? address { get; set; }
        [Required] public string carId { get; set; } = null!;

        [Required] public string carManufacture { get; set; } = null!;

        [Required] public string carModel { get; set; } = null!;

        [Required] public string carEngine { get; set; } = null!;

        [Required] public int carYear { get; set; }

        [Required] public int carKilometer { get; set; }

        [Required] public string vinNumber { get; set; } = null!;

    }
}
