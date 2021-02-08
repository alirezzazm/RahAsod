using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class RegisterCustomer : IdentityUser
    {
        [Display(Name = "نوع کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(10, ErrorMessage = "تعداد کاراکتر ورودی بیش از حد مجاز است")]
        public string CustomerType { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50, ErrorMessage = "تعداد کاراکتر ورودی بیش از حد مجاز است")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگي")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(60, ErrorMessage = "تعداد کاراکتر ورودی بیش از حد مجاز است")]
        public string LastName { get; set; }

        [Display(Name = "کد ملي")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [RegularExpression("(^[0]*[1-9]+[0-9]*)|([1-9][0-9]*)", ErrorMessage = "فقط عدد وارد کنید")]
        [MaxLength(20, ErrorMessage = "تعداد کاراکتر ورودی بیش از حد مجاز است")]
        [NotMapped]
        public string CustomerNationalCode { get; set; }

        [Display(Name = "کد اقتصادي")]
        [RegularExpression("(^[0]*[1-9]+[0-9]*)|([1-9][0-9]*)", ErrorMessage = "فقط عدد وارد کنید")]
        [MaxLength(30, ErrorMessage = "تعداد کاراکتر ورودی بیش از حد مجاز است")]
        public string CustomerEconomicCode { get; set; }

        [Display(Name = "تاريخ تولد")]
        [MaxLength(30, ErrorMessage = "تعداد کاراکتر ورودی بیش از حد مجاز است")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "0")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CustomerBirthday { get; set; }


        [Display(Name = "تلفن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [RegularExpression("(^[0]*[1-9]+[0-9]*)|([1-9][0-9]*)", ErrorMessage = "فقط عدد وارد کنید")]
        public int HomeNumber { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string Address { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string Password { get; set; }

        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [Compare("Password", ErrorMessage = "مطابقت ندارد")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
}
