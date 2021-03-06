﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نوع ماشين")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string VehicleType { get; set; }

        [Display(Name = "نام ماشين")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(100)]
        public string CarName { get; set; }

        [Display(Name = "تعداد سيلندر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int CylinderNmber { get; set; }

        [Display(Name = "ظرفيت مجاز")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int PermittedCapacity { get; set; }

        [Display(Name = "ظرفيت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(100)]
        public string Capacity { get; set; }

        [Display(Name = "زيرگروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(100)]
        public string Subgroup { get; set; }
    }
}
