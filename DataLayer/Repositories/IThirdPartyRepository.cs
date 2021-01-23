using DataLayer.Models;
using DataLayer.Models.Descriptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories
{
    public interface IThirdPartyRepository :IDisposable
    {
        bool AddNewThirdParty(DescriptionOfThirdPartyInsurance thirdparty);
        bool UpdateThirdParty(DescriptionOfThirdPartyInsurance thirdparty);
        bool DeleteThirdparty(DescriptionOfThirdPartyInsurance thirdparty);

        IEnumerable<DescriptionOfThirdPartyInsurance> ShowAllThirdparty();
        void Save();
    }
}
