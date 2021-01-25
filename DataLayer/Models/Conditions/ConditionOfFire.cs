using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Conditions
{
   public class ConditionOfFire
    {
        [Key]
        public int CarFireInsuranceID { get; set; }
        [Display(Name = "نام شرط جدید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string ConditionNewName { get; set; }

        [Display(Name = "درصد ضریب شرط")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float FireConditionCoefficientPercentage { get; set; }
    }
}
