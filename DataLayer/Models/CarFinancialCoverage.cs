using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
   public class CarFinancialCoverage
    {
        [Key]
        public int CarThirdPartyInsuranceFinancialCoverageID { get; set; }

        [Display(Name = "مقدار پایه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float BasePrice { get; set; }

        [Display(Name = "ضریب مالی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float FinancialCoefficient { get; set; }
    }
}
