using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Descriptions
{
    public class DescriptionOfLifeInsurance
    {
        //شرح بیمه نامه عمر
        [Key]
        public int LifeID { get; set; }

        [Display(Name = "تاریخ تولد مشتری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CustomerBirthday { get; set; }

        [Display(Name = "شغل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CustomerJob { get; set; }

        [Display(Name = "نحوه پرداخت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string PaymentMethod { get; set; }

        [Display(Name = "مدت بیمه نامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int CustomerTermOfInsurance { get; set; }

        [Display(Name = "حداقل مبلغ واریزی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float MinimumDepositMoney { get; set; }

        [Display(Name = "ایا بیمه نامه عمر قبلی دارید؟")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public bool HavePreviousLifeInsurance { get; set; }

    }
}
