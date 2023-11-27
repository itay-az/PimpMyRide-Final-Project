using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PimpMyRideServer.Models
{
    public class CarService
    {
        [Key] public int id { get; set; }
    
        public class MinService
        {
            public string minServiceDescription { get; set; } = "Oil and Oil Filter";

            public int minServicePrice { get; set; } = 300;

            public double minDuration { get; set; } = 1;


        }

        public class MiddleService : MinService
        {

            public string middleServiceDescription { get; set; }
            public int middleServicePrice { get; set; }
            public double middleDuration { get; set; }

            public MiddleService()
            {
                middleServiceDescription= "Air filter and Ac filter and " + base.minServiceDescription;
                middleServicePrice = base.minServicePrice + 200;
                middleDuration = base.minDuration + 0.3;
            }

        }

        public class BigService : MiddleService
        {

            public string bigServiceDescription { get; set; }
            public int bigServicePrice { get; set; }
            public double bigDuration { get; set; }

            public BigService()
            {
                bigServiceDescription = "Spark plugs and Belts and " + base.minServiceDescription;
                middleServicePrice = base.minServicePrice + 400;
                middleDuration = base.middleDuration + 1.0;
            }

        }

    }
}
