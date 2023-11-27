using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Models
{
    public class OrderPart
    {
        [Key] public string partId { get; set; }
        [Required] public string partName { get; set; }
        [Required] public decimal price { get; set; }
        [Required] public decimal quantity { get; set; }
    }
}
