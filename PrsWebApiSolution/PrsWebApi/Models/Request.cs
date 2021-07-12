using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrsWebApi.Models
{
    public class Request
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        [StringLength(200), Required]
        public string Description { get; set; }
        [StringLength(150), Required]
        public string Justification { get; set; }
        public DateTime DateNeeded { get; set; }
        [StringLength(10), Required]
        public string DeliveryMode { get; set; }
        [StringLength(10), Required]
        public string Status { get; set; } = "New";
        [Column(TypeName = "decimal(12,2)")]
        public decimal Total { get; set; }
        public DateTime DateSubmitted { get; set; } = DateTime.Now;
        [StringLength(150)]
        public string ReasonForRejection { get; set; }


    }
}
