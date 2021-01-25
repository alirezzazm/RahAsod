using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Descriptions
{

    //شرح بیمه های شخص ثالث مشتری
    public class DescriptionOfThirdPartyInsurance
    {
        [Key]
        public int ThirdPartyID { get; set; }
        [RegularExpression("([۱-۹\\d]{2}[\u0600-\u06FF][۱-۹\\d]{3}-([۱-۹\\d]{2}))|([۱-۹\\d]{3}-[۱-۹\\d]{5})", ErrorMessage = "فرمت ورودی اشتباه است")]
        [Display(Name = " پلاک خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string CarTag { get; set; }

        [Display(Name = "مدل خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int CarModel { get; set; }

        [Display(Name = "نوع خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string CarType { get; set; }

        [Display(Name = "تيپ خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string CarBrigade { get; set; }

        [Display(Name = "شماره شاسي")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string CarChassisNumber { get; set; }

        [Display(Name = "شماره موتور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string CarEngineNumber { get; set; }

        [Display(Name = "رنگ خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(20)]
        public string CarColor { get; set; }

        [Display(Name = "VIN خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string CarVin { get; set; }

        [Display(Name = "درصد تخفيف راننده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string DriverDiscountPercentage { get; set; }

        [Display(Name = "درصد تخفيف بيمه نامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string PolicyDicountPercantage { get; set; }

        [Display(Name = "مورد استفاده ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(20)]
        public string CarUsage { get; set; }

        [Display(Name = "ظرفيت ماشين")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(10)]
        public string CarCapacity { get; set; }

        [Display(Name = "يدک کش دارد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public bool TowTruckCar { get; set; }

        public int CarThirdPartyInsuranceFinancialCoverageID { get; set; }


    }
}



