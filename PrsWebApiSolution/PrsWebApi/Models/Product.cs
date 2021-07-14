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
        public int VendorID { get; set; }
        public virtual Vendor Vendor { get; set; }
        [StringLength(15), Required]
        public string PartNumber { get; set; }
        [StringLength(250), Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Price { get; set; }
        [StringLength(25), Required]
        public string Unit { get; set; }
        [StringLength(250)]
        public string PhotoPath { get; set; }
    }
}
