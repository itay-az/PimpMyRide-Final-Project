using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Client
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public DateTime dateTime { get; set; }
        public List<Car> cars { get; set; }

        public Client(string id, string name, string phone, string email,string address,Car car)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.dateTime = DateTime.Now;
            this.cars = new List<Car>();
            cars.Add(car);
        }
    }
}
