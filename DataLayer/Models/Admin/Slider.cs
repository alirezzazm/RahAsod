using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Admin
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "آدرس عکس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        public string picPath { get; set; }

        [Display(Name = "نمايش داده شود ؟")]
        public bool show { get; set; }
    }
}
