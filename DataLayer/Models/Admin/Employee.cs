using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Admin
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [Display(Name = "نام و نام خانوادگي")]
        [MaxLength(50)]
        public string fullName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [Display(Name = "سمت")]
        [MaxLength(30)]
        public string position { get; set; }
    }
}
