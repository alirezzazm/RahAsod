using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.InsurancesDescription
{
    public class DescriptionOfLifeInsurance
    {
        //شرح بیمه نامه عمر
        [Key]
        public int LifeID { get; set; }
        [Display(Name = "تاریخ تولد مشتری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public DateTime DateOfBirthCustomer { get; set; }
        [Display(Name = "شغل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string TitleJobCustomer { get; set; }
        [Display(Name = "نحوه پرداخت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string HowToPayInsuranceOfCustomer { get; set; }
        [Display(Name = "مدت بیمه نامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int TermOfCustomerInsurance { get; set; }
        [Display(Name = "قیمت خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float MinimumDepositMoneyCustomer { get; set; }
        [Display(Name = "ایا بیمه نامه عمر قبلی دارید؟")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public bool DoYouHaveAPreviousLifeInsurancePolicy { get; set; }

    }
}
