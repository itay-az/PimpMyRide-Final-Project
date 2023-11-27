using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Models
{
    public class Manufacture
    {
        [Key][Required] public string manufacturerName { get; set; }

        public Manufacture() { }



    }
}
