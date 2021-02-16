using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Models.Admin;
using DataLayer.Models.Descriptions;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void SaveAsync()
        {
            _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public bool AddNewCar(Car newcar)
        {
            try
            {
                _context.Add(newcar);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<string> ShowCarNames()
        {
            return _context.CarTypes.Select(n => n.CarName);
        }

        public IEnumerable<Car> ShowAllCars()
        {
            return _context.CarTypes;
        }

        public bool AddFinancialCoverage(CarFinancialCoverage financialCoverage)
        {
            try
            {
                _context.Add(financialCoverage);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<CarFinancialCoverage> ShowFinancialCoverages()
        {
            return _context.CarFinancialCoverages;
        }
               
    }
}
