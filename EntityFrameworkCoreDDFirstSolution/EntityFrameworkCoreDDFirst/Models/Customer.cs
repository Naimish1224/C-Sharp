using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCoreDDFirst.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public decimal Sales { get; set; }
        public bool Active { get; set; } = true;
    }
}
