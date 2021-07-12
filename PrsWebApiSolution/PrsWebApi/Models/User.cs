using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BmdbWebApi.Models
{
    public class User
    {
        public int ID { get; set; }
        [StringLength(30), Required]
        public string UserName { get; set; }
        [StringLength(30), Required]
        public string Password { get; set; }
        [StringLength(30), Required]
        public string FirstName { get; set; }
        [StringLength(30), Required]
        public string LastName { get; set; }
        [StringLength(15), Required]
        public string Phone { get; set; }
        [StringLength(50), Required]
        public string Email { get; set; }
        public bool Reviewer { get; set; }
        public bool Admin { get; set; }


    }
}
