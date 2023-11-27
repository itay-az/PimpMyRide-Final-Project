using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class CauseOfArrival
    {
       public int id { get; set; }
       public string reason { get; set; }

        public CauseOfArrival(int id, string reason)
        {
            this.id = id;
            this.reason = reason;
        }

    }
}
