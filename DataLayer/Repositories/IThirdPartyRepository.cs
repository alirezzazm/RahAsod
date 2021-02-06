using DataLayer.Models;
using DataLayer.Models.Descriptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories
{
    public interface IThirdPartyRepository :IDisposable
    {
        //ThirdParty
        bool AddNewThirdParty(DescriptionOfThirdPartyInsurance thirdparty);
        bool UpdateThirdParty(DescriptionOfThirdPartyInsurance thirdparty);
        bool DeleteThirdparty(DescriptionOfThirdPartyInsurance thirdparty);

        IEnumerable<DescriptionOfThirdPartyInsurance> ShowAllThirdparty();

        //Cars
        bool AddNewCar(Car newcar);
        IEnumerable<string> ShowCarNames();
        IEnumerable<Car> ShowAllCars();






        void Save();
    }
}
