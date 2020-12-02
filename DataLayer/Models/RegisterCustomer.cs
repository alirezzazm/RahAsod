using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
   public class RegisterCustomer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NumberPhone { get; set; }
        public string NationalCode { get; set; }
        public string Adrress { get; set; }
        public string Email { get; set; }
        public string HomeNumber { get; set; }
        public string InsurancesForCustomer { get; set; }
    }
}
