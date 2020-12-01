using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RahAsod.Model
{
    //شرح بیمه های شخص ثالث مشتری
    public class DescriptionThirdPartyCarModel
    {           
        public int DescriptionThirdPartyCarID { get; set; }
        public string TagCar { get; set; }
        public int ModelCar { get; set; }
        public string TypeOfCar { get; set; }
        public string StyleCar { get; set; }
        public string ChassisNumberCar { get; set; }
        public string EngineNumberCar { get; set; }
        public string ColorCar { get; set; }
        public string VinCar { get; set; }
        public string DriverDiscountPercentage { get; set; }
        public string PercentageOfInsuranceDiscount { get; set; }   
        public string UsedCar { get; set; }
        public string CapacityCar { get; set; }
        public bool TowTruckCar { get; set; }

    }
}
