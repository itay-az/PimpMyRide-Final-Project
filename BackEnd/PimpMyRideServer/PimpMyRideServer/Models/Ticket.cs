using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class Ticket
    {
        [Key] public int ticketId { get; set; }
        [Required] public string carId { get; set; }
        [Required] public string clientId { get; set; }
        [Required] public string problems { get; set; }
        [Required] public List<TicketPart> parts { get; set; } = new();
        [Required] public List<TicketLabor> labors { get; set; } = new();
        public DateTime dateTime { get; set; }
        public double totalPartsPrice { get; set; }
        public double totalPartsDiscount { get; set; }

        public double totalLaborPrice { get; set; }
        public double totalLaborDiscount { get; set; }
        public double price { get; set; }
        public bool isOpen { get; set; } = true;

    


        public Ticket() { }

        public Ticket(string carId, string clientId, string problems, List<TicketPart> parts, List<TicketLabor> labors)
        {
            this.carId = carId;
            this.clientId = clientId;
            this.problems = problems;
            this.parts = parts;
            this.labors = labors;
            this.dateTime = DateTime.Now;
            this.price = 0;

        }
        public Ticket(string carId, string clientId, string problems)
        {
            this.carId = carId;
            this.clientId = clientId;
            this.problems = problems;
            this.parts = new List<TicketPart>();
            this.labors = new List<TicketLabor>();
            this.dateTime = DateTime.Now;
            this.price = 0;
        }

        // calculate total parts cost
        public void calculatePartPrice()
        {
            double priceTmp = 0;
            double discountTmp = 0;

            if (this.parts.Count > 0)
            {
                foreach (var part in this.parts)
                {
                    priceTmp += Decimal.ToDouble(part.price);
                    discountTmp += Decimal.ToDouble(part.discount);
                }
                this.totalPartsDiscount = priceTmp * (discountTmp * 0.01);
                this.totalPartsPrice = priceTmp - totalPartsDiscount;
            }
            else
            { this.totalPartsPrice = 0; }
        }

        // calculate total labor cost

        public void calculateLaborPrice()
        {
            double priceTmp = 0;
            double discountTmp = 0;
            if (this.labors.Count > 0)
            {
                foreach (var labor in this.labors)
                {
                    priceTmp += Decimal.ToDouble(labor.time) * Decimal.ToDouble(labor.price);
                    discountTmp += Decimal.ToDouble(labor.discount);
                }
                this.totalLaborDiscount = priceTmp * (discountTmp * 0.01);
                this.totalLaborPrice = priceTmp - totalLaborDiscount;
            }
            else
                this.totalLaborPrice = 0;
        }

        // calculate total cost

        public void calculateTotalPrice()
        {
            this.price = this.totalPartsPrice + this.totalLaborPrice;
        }




        public void calculate()
        {
            calculatePartPrice();
            calculateLaborPrice();
            calculateTotalPrice();

        }


    }
}
