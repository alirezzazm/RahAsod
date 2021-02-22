using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models.Admin
{
    public class DescriptionTexts
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "متن توضيحات")]
        public string Text { get; set; }

        [Display(Name = "نوع بيمه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنيد ")]
        [MaxLength(50)]
        public string InsuranceType { get; set; }

    }
}
