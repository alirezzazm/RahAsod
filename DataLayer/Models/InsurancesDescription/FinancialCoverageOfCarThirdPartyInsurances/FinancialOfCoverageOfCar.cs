using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.InsurancesDescription.FinancialCoverageCarThirdPartyInsurances
{
    public class FinancialOfCoverageOfCar
    {
        [Key]
        public int FinancialCoverageOfCarThirdPartyInsurancesID { get; set; }

        [Display(Name = "مقدار مالی را اضافه کنید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string FinancialSelected { get; set; }

        public float FinancialValue { get; set; }
    }
}
