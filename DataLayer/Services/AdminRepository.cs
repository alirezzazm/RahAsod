using DataLayer.Context;
using DataLayer.Models.Admin;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Services
{
    public class AdminRepository : IAdminRepository
    {
        private InsuranceContext _context;
        public AdminRepository(InsuranceContext context)
        {
            _context = context;
        }


        //Slider
        public IEnumerable<Slider> GetAllSliders()
        {
            return _context.SliderPics;
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
            return _context.SliderPics.Where(s => s.show == true).Select(p => p.picName);
        }

        public Slider GetSliderById(int id)
        {
            return _context.SliderPics.FirstOrDefault(m => m.Id == id);
        }

        public bool EditSlider(Slider model)
        {
            try
            {
                _context.Entry(model).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteSlider(Slider slider)
        {
            try
            {
                _context.Entry(slider).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SliderExists(int id)
        {
            return _context.SliderPics.Any(e => e.Id == id);
        }
        //EndSlider



        //Employee
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees;
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(m => m.Id == id);
        }

        public bool EditEmployee(Employee employee)
        {
            try
            {
                _context.Entry(employee).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }

        public bool DeleteEmployee(Employee employee)
        {
            try
            {
                _context.Entry(employee).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //EndEmployee


        //OfficeInfo
        public List<OfficeInfo> GetOfficeInfo()
        {
            return _context.OfficeInfos.ToList();
        }

        public bool EditOfficeInfo(OfficeInfo info)
        {
            try
            {
                _context.Entry(info).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public OfficeInfo GetInfoById(int id)
        {
            return _context.OfficeInfos.FirstOrDefault(m => m.Id == id);
        }

        public bool OfficeInfoExists(int id)
        {
            return _context.OfficeInfos.Any(e => e.Id == id);
        }
        //EndOfficeInfo



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
