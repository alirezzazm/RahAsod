using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    public class RegisterCustomer :IdentityUser
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
        [RegularExpression("(^[0]*[1-9]+[0-9]*)|([1-9][0-9]*)",ErrorMessage ="فقط عدد وارد کنید")]
        public string CustomerNationalCode { get; set; }
              

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
        public string Password { get; set; }

        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [Compare("Password",ErrorMessage ="مطابقت ندارد")]
        public string ConfirmPassword { get; set; }
            
    }
}
