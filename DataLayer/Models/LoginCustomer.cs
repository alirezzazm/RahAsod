using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
   public class LoginCustomer
    {
        [Key]
        public int NationalCode { get; set; }
    }
}
