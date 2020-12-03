using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.InsurancesDescription
{
    public class DescriptionOfBodyInsurance
    {
        [Key]
        public int BodyID { get; set; }

        [Display(Name = "قیمت خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float CarPrice { get; set; }

        [Display(Name = "خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CarTag { get; set; }

        [Display(Name = "مدل خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int CarModel { get; set; }

        [Display(Name = "نوع خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string TypeOfCar { get; set; }

        [Display(Name = "تيپ خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string StyleCar { get; set; }

        [Display(Name = "شماره شاسي")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CarChassisNumber { get; set; }

        [Display(Name = "شماره موتور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CarEngineNumber { get; set; }

        [Display(Name = "رنگ خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CarColor { get; set; }

        [Display(Name = "VIN خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string VinCar { get; set; }

        [Display(Name = "درصد تخفيف بيمه نامه قبلی خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string PercentageOfInsuranceDiscount { get; set; }

        [Display(Name = "مورد استفاده ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string UsedCar { get; set; }

        [Display(Name = "ظرفيت ماشين")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CarCapacity { get; set; }

        [Display(Name = "يدک کش دارد یا خیر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public bool TowTruckCar { get; set; }

        public int ConditionOfCarBodyInsurancesID { get; set; }

    }
}
