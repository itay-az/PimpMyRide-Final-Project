using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class Ticket
    {
        [Key] public int ticketId { get; set; }
        [Required] public string carId { get; set; }
        [Required] public string clientFullName { get; set; }
        [Required] public string clientId { get; set; }
        [Required] public string clientPhone { get; set; }
        [Required] public string clientEmail { get; set; }
        [Required] public string problems { get; set; }
        [Required] public List<TicketPart> parts { get; set; } = new();
        [Required] public List<TicketLabor> labors { get; set; } = new();
        public DateTime dateTime { get; set; }
        public double totalPartsPrice { get; set; }
        public double totalPartsDiscount { get; set; }

        public double totalLaborPrice { get; set; }
        public double totalLaborDiscount { get; set; }
        public double price { get; set; }
        [Required]
        [EnumDataType(typeof(JobTitle))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TicketType state { get; set; }

    


        public Ticket() { }

        public Ticket(string carId, string clientId, string problems,string clientFullName, string clientPhone, string clientEmail, List<TicketPart> parts, List<TicketLabor> labors,TicketType ticketType)
        {
            this.carId = carId;
            this.clientId = clientId;
            this.problems = problems;
            this.parts = parts;
            this.labors = labors;
            this.dateTime = DateTime.Now;
            this.price = 0;
            this.state = ticketType;
            this.clientPhone = clientPhone;
            this.clientEmail = clientEmail;
            this.clientFullName = clientFullName;

        }
        public Ticket(string carId,string clientFullName, string clientId,string clientPhone, string clientEmail, string problems)
        {
            this.carId = carId;
            this.clientId = clientId;
            this.problems = problems;
            this.parts = new List<TicketPart>();
            this.labors = new List<TicketLabor>();
            this.dateTime = DateTime.Now;
            this.price = 0;
            this.state = TicketType.IS_OPEN;
            this.clientPhone = clientPhone;
            this.clientEmail = clientEmail;
            this.clientFullName = clientFullName;
        }

        public Ticket(string carId, string clientId, string problems, TicketType ticketType)
        {
            this.carId = carId;
            this.clientId = clientId;
            this.problems = problems;
            this.parts = new List<TicketPart>();
            this.labors = new List<TicketLabor>();
            this.dateTime = DateTime.Now;
            this.price = 0;
            this.state = ticketType;
        }

        public Ticket(string carId, string clientFullName, string clientId, string clientPhone, string clientEmail, string problems, TicketType ticketType)
        {
            this.carId = carId;
            this.clientId = clientId;
            this.problems = problems;
            this.parts = new List<TicketPart>();
            this.labors = new List<TicketLabor>();
            this.dateTime = DateTime.Now;
            this.price = 0;
            this.state = ticketType;
            this.clientPhone = clientPhone;
            this.clientEmail = clientEmail;
            this.clientFullName = clientFullName;
        }



    }
}
