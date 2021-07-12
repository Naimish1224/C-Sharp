using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrsWebApi.Models
{
    public class LineItem
    {
        public int ID { get; set; }
        public int RequestID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
