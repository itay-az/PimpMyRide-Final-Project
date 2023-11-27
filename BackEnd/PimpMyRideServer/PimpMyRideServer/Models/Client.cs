using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class Client
    {
        public Client() { }
        public Client(string id, string name, string phone, string? email, string? address, List<Car> cars)
        {
            this.clientId = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.cars = cars;
            this.dateTime = DateTime.Now;
        }

        [Key] public string clientId { get; set; } = null!;
        [Required] public string name { get; set; } = null!;

        [Required] public string phone { get; set; } = null!;
        public string? email { get; set; }
        public string? address { get; set; }
        public DateTime dateTime { get; set; }

        [Required]
        [InverseProperty("Client")]
        public List<Car> cars { get; set;} = new List<Car>();

    }
}
