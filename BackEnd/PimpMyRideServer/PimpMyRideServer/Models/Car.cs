using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PimpMyRideServer.Models
{
    public class Car
    {
        public Car() { }
        public Car(string carId, string clientId, string carManufacture, string carModel, string carEngine, int carYear, int carKilometer, string vinNumber)
        {
            this.carId = carId;
            this.clientId = clientId;
            this.carManufacture = carManufacture;
            this.carModel = carModel;
            this.carEngine = carEngine;
            this.carYear = carYear;
            this.carKilometer = carKilometer;
            this.vinNumber = vinNumber;
            this.dateTime = DateTime.Now;
            this.ticketIds = new List<int>();
        }

        [Key] public string carId { get; set; } = null!;
        [Required]  public string clientId { get; set; }
        [ForeignKey("clientId")]

        [JsonIgnore]
        [Required] public Client Client { get; set; } = null!;
        [Required] public string carManufacture { get; set; } = null!;
        [Required] public string carModel { get;set; } = null!;
        [Required] public string carEngine { get; set; } = null!;

        [Required] public int carYear { get; set; }

        [Required] public int carKilometer { get; set; }

        [Required] public string vinNumber { get; set; } = null!;
        public DateTime dateTime { get; set; }
        public List<int> ticketIds { get; set; } = new List<int>();
         

    }
}
