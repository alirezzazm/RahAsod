using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.InsurancesDescription
{
   public class DescriptionOfFireInsurance
    {
        [Key]
        public int FireID { get; set; }
        [Display(Name = "محل مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string ProvinceOfInsuredPlace { get; set; }
        [Display(Name = "شهر مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CityOfTheInsuredPlace { get; set; }
        [Display(Name = "آدرس مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string AddressOfTheInsuredPlace { get; set; }
        [Display(Name = "کدپستی مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string PostalCodeOfTheInsuredPlace { get; set; }
        [Display(Name = "نوع سازه ساختمان مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string TypeOfStructureAndBuildingMaterials { get; set; }
        [Display(Name = "مقدار زیر ساخت مورد بیمه  ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string BuildingInfrastructure { get; set; }
        [Display(Name = "تعداد واحدهای بیمه شده ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string NumberOfInsuredUnits { get; set; }
        [Display(Name = "سرمایه مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string InsuredCapital { get; set; }
        [Display(Name = "سرمایه اثاثیه موردبیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string InsuredMortgageCapital { get; set; }

        public int ConditionOfCarFireInsurancesID { get; set; }

    }

}
