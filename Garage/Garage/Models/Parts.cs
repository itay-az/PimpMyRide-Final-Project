﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class Parts
    {
        public string partId { get; set; }
        public string partName { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
    
    }
}
