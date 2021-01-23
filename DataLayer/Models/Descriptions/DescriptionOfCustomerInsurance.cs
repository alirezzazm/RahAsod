using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Descriptions
{
    public class DescriptionOfCustomerInsurance
    {
        //شرح بیمه های مشتری
        [Key]

        public int DescriptionInsurancesID { get; set; }

        public string NameInsurances { get; set; }
        [Display(Name = "شماره بیمه نامه قبلی ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string PreviousNumberInsurance { get; set; }
        [Display(Name = "شماره بیمه نامه  ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string NumberInsurances { get; set; }
        [Display(Name = "شرکت بیمه  ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CompanyName { get; set; }
        [Display(Name = "شماره بیمه نامه قبلی ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string PreviousCompanyName { get; set; }
        [Display(Name = "شروع بیمه نامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string StartInsurances { get; set; }
        [Display(Name = "پایان بیمه نامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string EndInsurances { get; set; }

        public string DescriptionInsurances { get; set; }
    }
}
