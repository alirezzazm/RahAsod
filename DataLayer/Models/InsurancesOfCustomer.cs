using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
   public class InsurancesOfCustomer
    {
        //مدل سازی بیمه های مشتری
        [Key]
        public int InsurancesForCustomerID { get; set; }
        public string NameInsurances { get; set; }
        public string DescriptionInsurances { get; set; }
    }
}
