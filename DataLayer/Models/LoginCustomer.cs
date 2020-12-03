using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
   public class LoginCustomer
    {
        //لاگین کردن مشتری
        [Key]
        [Display(Name = "کدملی ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int NationalCodeCustomer { get; set; }
        [Display(Name = "پسوورد ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string PasswordCustomer { get; set; }
    }
}
