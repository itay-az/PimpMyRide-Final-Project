using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Car
    {
        public string carId { get; set; }
        public string clientId { get; set; }

        public string carManufacture { get; set; }

        public string carModel { get; set; }

        public string carEngine { get; set; }

        public int carYear { get; set; }

        public int carKilometer { get; set; }


        public string vinNumber { get; set; }
        public DateTime dateTime { get; set; }

        public Car(string carId,string clientId, string carManufacture, string carModel, string  carEngine, int carYear,string vinNumber, int carKilometer)
        {
            this.carId = carId;
            this.clientId = clientId;
            this.carManufacture = carManufacture;
            this.carModel = carModel;
            this.carEngine = carEngine;
            this.carYear = carYear;
            this.vinNumber = vinNumber;
            this.carKilometer = carKilometer;
            this.dateTime = DateTime.Now;
        }


    }
}
