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


        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگي")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string LastName { get; set; }

        [Display(Name = "کد ملي")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string NationalCode { get; set; }

        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string PhoneNumber { get; set; }

        [Display(Name = "تلفن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string HomeNumber { get; set; }

        [Display(Name = "ايميل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string Adrress { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int Password { get; set; }

        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int ConfirmPassword { get; set; }

        //[Display(Name = "")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        //public string InsurancesForCustomer { get; set; }

        //[Display(Name = "نام ")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        //public string NameCustomer { get; set; }
        //[Display(Name = "نام ونام خانوادگی ")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        //public string FamilyCustomer { get; set; }
        //[Display(Name = "شماره همراه  ")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        //public string NumberPhoneCustomer { get; set; }
        //[Display(Name = "کد ملی ")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        //public string NationalCodeCustomer { get; set; }
        //[Display(Name = "آدرس ")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        //public string AdrressCustomer { get; set; }
        //[Display(Name = "ایمیل ")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        //public string EmailCustomer { get; set; }
        //[Display(Name = "شماره منزل ")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        //public string HomeNumberCustomer { get; set; }


    }
}
