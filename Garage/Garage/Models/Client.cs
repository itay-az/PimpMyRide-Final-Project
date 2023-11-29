using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Client
    {
        public string clientId { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public DateTime dateTime { get; set; }
        public List<Car> cars { get; set; }

        public Client() { }

        public Client(string clientId, string name, string phone, string email,string address,Car car)
        {
            this.clientId = clientId;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.dateTime = DateTime.Now;
            this.cars = new List<Car>();
            cars.Add(car);
        }
        public Client(string clientId, string name, string phone, string email, string address, List<Car> cars)
        {
            this.clientId = clientId;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.dateTime = DateTime.Now;
            this.cars = cars;
        }
    }
}
