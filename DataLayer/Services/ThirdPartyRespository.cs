using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Services
{
    public class ThirdPartyRespository : IThirdPartyRepository
    {

        private InsuranceContext _context;
        public ThirdPartyRespository(InsuranceContext context)
        {
            _context = context;
        }


        public bool AddNewThirdParty(DescriptionOfThirdPartyInsurance thirdparty)
        {
            try
            {
                _context.ThirdPartyInsurance.Add(thirdparty);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteThirdparty(DescriptionOfThirdPartyInsurance thirdparty)
        {
            try
            {
                _context.Entry(thirdparty).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public IEnumerable<DescriptionOfThirdPartyInsurance> ShowAllThirdparty()
        {
            return _context.ThirdPartyInsurance;
        }


        public bool UpdateThirdParty(DescriptionOfThirdPartyInsurance thirdparty)
        {
            try
            {
                _context.Entry(thirdparty).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
