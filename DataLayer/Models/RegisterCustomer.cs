using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
   public class RegisterCustomer
    {
        //ثبت نام و دریافت اطلاعات مشتری
        [Key]
        public int CustomerID { get; set; }
        [Display(Name = "نام ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string NameCustomer { get; set; }
        [Display(Name = "نام ونام خانوادگی ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string FamilyCustomer { get; set; }
        [Display(Name = "شماره همراه  ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string NumberPhoneCustomer { get; set; }
        [Display(Name = "کد ملی ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string NationalCodeCustomer { get; set; }
        [Display(Name = "آدرس ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string AdrressCustomer { get; set; }
        [Display(Name = "ایمیل ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string EmailCustomer { get; set; }
        [Display(Name = "شماره منزل ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string HomeNumberCustomer { get; set; }

    }
}
