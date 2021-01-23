using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Conditions
{
    //اضافه کردن شرط برای بیمه بدنه از طریق ادمین
    public class ConditionOfCarBody
    {
        [Key]
        public int CarBodyInsurancesConditionID { get; set; }
        [Display(Name = "اسم شرط جدید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string ConditionBodyNewName { get; set; }

        [Display(Name = "درصد ضریب شرط را وارد کنید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float BodyConditionCoefficientPercentage { get; set; }
    }
}
