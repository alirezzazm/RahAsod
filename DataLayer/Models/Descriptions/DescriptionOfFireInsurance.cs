using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Descriptions
{
   public class DescriptionOfFireInsurance
    {
        [Key]
        public int FireID { get; set; }

        [Display(Name = "استان مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(30)]
        public string Province { get; set; }

        [Display(Name = "شهر مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(30)]
        public string City { get; set; }

        [Display(Name = "آدرس مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string Address { get; set; }

        [Display(Name = "کدپستی مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string PostalCode { get; set; }

        [Display(Name = "نوع سازه ساختمان مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(20)]
        public string TypeOfBuildingStructure { get; set; }

        [Display(Name = "مقدار زیر ساخت مورد بیمه  ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string BuildingInfrastructure { get; set; }

        [Display(Name = "تعداد واحدهای بیمه شده ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(10)]
        public string InsuredUnitsNumber { get; set; }

        [Display(Name = "سرمایه مورد بیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string InsuredCapital { get; set; }

        [Display(Name = "سرمایه اثاثیه موردبیمه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float HomeFurnitureCapital { get; set; }

        public int CarFireInsuranceID { get; set; }

    }

}
