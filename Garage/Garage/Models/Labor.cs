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
        public float price { get; set; }
    }
}
