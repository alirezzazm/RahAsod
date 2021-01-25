using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Descriptions
{
    //شرح بیمه نامه بدنه مشتری
    public class DescriptionOfBodyInsurance
    {
        [Key]
        public int BodyID { get; set; }

        [Display(Name = "قیمت خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public float CarPrice { get; set; }

        [Display(Name = "پلاک خودرو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [RegularExpression("([۱-۹\\d]{2}[\u0600-\u06FF][۱-۹\\d]{3}-([۱-۹\\d]{2}))|([۱-۹\\d]{3}-[۱-۹\\d]{5})", ErrorMessage = "فرمت ورودی اشتباه است")]
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
        [MaxLength(20)]
        public string CarStyle { get; set; }

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

        [Display(Name = "درصد تخفيف بيمه نامه قبلی خودرو")]
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
        public bool HaveTowTruckCar { get; set; }

        public int CarBodyInsurancesConditionID { get; set; }

    }
}
