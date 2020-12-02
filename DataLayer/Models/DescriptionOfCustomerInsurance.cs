using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    public class DescriptionOfCustomerInsurance
    {
        //شرح بیمه های مشتری
        [Key]
        public int DescriptionInsurancesID { get; set; }
        public string NameInsurances { get; set; }
        public string PreviousNumberInsurance { get; set; }
        public string NumberInsurances { get; set; }
        public string CompanyName { get; set; }
        public string PreviousCompanyName { get; set; }
        public string StartInsurances { get; set; }
        public string EndInsurances { get; set; }
        public string DescriptionInsurances { get; set; }
    }
}
