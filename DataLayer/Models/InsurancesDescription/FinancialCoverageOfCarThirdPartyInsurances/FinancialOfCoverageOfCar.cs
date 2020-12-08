using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.InsurancesDescription.FinancialCoverageCarThirdPartyInsurances
{

    //مدلسازی برای اضافه کردن مالی های جدید از طریق ادمین
    public class FinancialOfCoverageOfCar
    {
        [Key]
        public int FinancialCoverageOfCarThirdPartyInsurancesID { get; set; }

        [Display(Name = "مقدار مالی را اضافه کنید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string FinancialSelected { get; set; }
        [Display(Name = "ضریب مالی را اضافه کنید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float FinancialValue { get; set; }
    }
}
