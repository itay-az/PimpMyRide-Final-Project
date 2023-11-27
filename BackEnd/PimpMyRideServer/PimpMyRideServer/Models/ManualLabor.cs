using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Models
{
    public class ManualLabor
    {
        [Key] public int Id { get; set; }
        [Required] public string description { get; set; }
        [Required] public decimal price { get; set; }
        [Required] public decimal time { get; set; }
        public decimal discount { get; set; }
    }
}
