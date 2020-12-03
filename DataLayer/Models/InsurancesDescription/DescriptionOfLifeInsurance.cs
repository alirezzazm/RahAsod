using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.InsurancesDescription
{
   public class DescriptionOfLifeInsurance
    {
        [Key]
        public int LifeID { get; set; }
        public string MyProperty { get; set; }
    }
}
