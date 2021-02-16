using DataLayer.Context;
using DataLayer.Models.Admin;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Services
{
   public class AdminRepository :IAdminRepository
    {
        private InsuranceContext _context;
        public AdminRepository(InsuranceContext context)
        {
            _context = context;
        }

        public bool AddPhoto(Slider sliderPhoto)
        {
            try
            {
                _context.SliderPics.Add(sliderPhoto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<string> PhotoName()
        {
            return _context.SliderPics.Where(s=>s.show==true).Select(p=>p.picName);
        }

        public void Dispose()
        {
            _context.Dispose();
        }


        public void save()
        {
            _context.SaveChanges();
        }
    }
}
