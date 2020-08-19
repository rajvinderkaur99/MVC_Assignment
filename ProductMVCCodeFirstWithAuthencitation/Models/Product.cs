using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductMVCCodeFirstWithAuthencitation.Models
{
    public class Product
    {
        public int Pid { get; set; }
        public string PName { get; set; }
        public int Rate { get; set; }
    }
}