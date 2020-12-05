﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.InsurancesDescription.ConditionOfCarBodyInsurances
{
    //اضافه کردن شرط برای بیمه بدنه از طریق ادمین
    public class ConditionOfCarBody
    {
        [Key]
        public int ConditionOfCarBodyInsurancesID { get; set; }
        [Display(Name = "اسم شرط جدید را وارد کنید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string NameConditionBody { get; set; }
        [Display(Name = "درصد ضریب شرط را وارد کنید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float AdditionalPercentageBody { get; set; }
    }
}
