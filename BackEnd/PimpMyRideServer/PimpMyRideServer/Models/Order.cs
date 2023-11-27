using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("orderId")] 
        public int orderId { get; set; }
        [Required] public List<OrderPart> parts { get; set; }
        [Required] public string supplierName { get; set; }

        [Required] public double price { get; set; }

        public DateTime dateTime { get; set; } = DateTime.Now;

        public Order() { }

        public Order(List<OrderPart> parts, string supplierName)
        {
            this.parts = parts;
            this.supplierName = supplierName;

            foreach(OrderPart part in parts)
            {
                this.price += (double)part.price * (double)part.quantity;
            }
            this.dateTime = DateTime.Now;
        }

        public void calculatePrice()
        {
            foreach (OrderPart part in parts)
            {
                this.price += (double)part.price * (double)part.quantity;
            }
        }

    }
}
