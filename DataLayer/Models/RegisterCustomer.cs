using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    public class RegisterCustomer
    {
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

        [Display(Name = "")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string InsurancesForCustomer { get; set; }
    }
}
