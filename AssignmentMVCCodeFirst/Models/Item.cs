using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AssignmentMVCCodeFirst.Models
{
    public class Item:DbContext
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
    }
}