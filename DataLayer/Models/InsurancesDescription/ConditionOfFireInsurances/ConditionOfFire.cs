using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.InsurancesDescription.ConditionOfFireInsurances
{
   public class ConditionOfFire
    {
        [Key]
        public int ConditionOfCarFireInsurancesID { get; set; }
        [Display(Name = "اسم شرط جدید را وارد کنید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string NameConditionFire { get; set; }
        [Display(Name = "درصد ضریب شرط را وارد کنید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float AdditionalPercentageFire { get; set; }
    }
}
