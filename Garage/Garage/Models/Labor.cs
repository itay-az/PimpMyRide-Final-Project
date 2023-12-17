using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Labor
    {
        public int Id { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public decimal time { get; set; }
        public decimal discount { get; set; }

        public Labor ()
        {

        }
        public Labor(string description, decimal price, decimal time)
        {
            this.description = description;
            this.price = price;
            this.time = time;
            this.discount = 0;
        }

        public Labor (int Id, string description, decimal price, decimal time)
        {
            this.Id = Id;
            this.description = description;
            this.price = price;
            this.time = time;
            this.discount = 0;
        }
        public Labor(int Id, string description, decimal price, decimal time,decimal discount)
        {
            this.Id = Id;
            this.description = description;
            this.price = price;
            this.time = time;
            this.discount = discount;
        }
    }


}
