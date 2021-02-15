using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Admin
{
    public class OfficeInfo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string adress { get; set; }

        [Display(Name = "تلفن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public int phoneNumber { get; set; }

        [Display(Name = "ايميل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "اينستاگرام")]
        [MaxLength(30)]
        public string instagram { get; set; }

        [Display(Name = "توضيحات")]
        public string description { get; set; }
    }
}
