using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
   public class CustomerLogin
    {
        //لاگین کردن مشتری
        [Key]
        [Display(Name = "کدملی ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [RegularExpression("(^[0]*[1-9]+[0-9]*)|([1-9][0-9]*)", ErrorMessage = "فقط عدد وارد کنید")]
        public string NationalCode { get; set; }

        [Display(Name = "رمز عبور ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string Password { get; set; }
    }
}
