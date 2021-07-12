using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrsWebApi.Models
{
    public class Product
    {
        public int ID { get; set; }
        [StringLength(3), Required]
        public int VendorID { get; set; }
        [StringLength(15), Required]
        public string PartNumber { get; set; }
        [StringLength(250), Required]
        public string Name { get; set; }
        [ColumnAttribute(), Required]
        public decimal Price { get; set; }
        [StringLength(6), Required]
        public int Unit { get; set; }
        [StringLength(250)]
        public string PhotoPath { get; set; }
    }
}
