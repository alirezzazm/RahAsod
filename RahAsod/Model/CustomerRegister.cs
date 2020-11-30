using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RahAsod.Model
{
    //مدل سازی برای مشخصات و ثبت نام مشتری
    public class CustomerRegister
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NumberPhone { get; set; }
        public string NationalCode { get; set; }
        public string Adrress { get; set; }
        public string Email { get; set; }
        public string HomeNumber { get; set; }
        public string InsurancesForCustomer { get; set; }
    }
}
