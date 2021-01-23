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
        public int NationalCode { get; set; }

        [Display(Name = "رمز عبور ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string Password { get; set; }
    }
}
