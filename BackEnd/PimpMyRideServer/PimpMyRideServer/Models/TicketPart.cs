using System.ComponentModel.DataAnnotations;

namespace PimpMyRideServer.Models
{
    public class TicketPart
    {
        [Key]public int Id { get; set; }
        [Required] public string partId { get; set; } = null!;
        [Required] public string partName { get; set; }
        [Required] public decimal price { get; set; }
        [Required] public decimal quantity { get; set; }
        public decimal discount { get; set; }
        public decimal unitPrice { get; set; }
        /*
        public decimal GetTotalPrice()
        {
            return price - (price * (discount * (decimal)0.01));
        }
        */
        public decimal GetTotalDiscount()
        {
            return price * (discount * (decimal)0.01);
        }
        
    }
}
