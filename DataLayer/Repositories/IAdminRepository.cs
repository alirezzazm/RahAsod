using DataLayer.Models.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories
{
    public interface IAdminRepository : IDisposable
    {
        //Slider
        IEnumerable<Slider> GetAllSliders();
        bool AddPhoto(Slider sliderPhoto);
        IEnumerable<string> PhotoName();
        Slider GetSliderById(int id);
        bool EditSlider(Slider model);
        bool SliderExists(int id);
        bool DeleteSlider(Slider slider);


        //Employee
        IEnumerable<Employee> GetAllEmployees();
        bool AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        bool EditEmployee(Employee model);
        bool EmployeeExists(int id);
        bool DeleteEmployee(Employee employee);


        //OfficeInfo
        List<OfficeInfo> GetOfficeInfo();
        bool EditOfficeInfo(OfficeInfo model);
        OfficeInfo GetInfoById(int id);
        bool OfficeInfoExists(int id);


        void save();

    }
}
