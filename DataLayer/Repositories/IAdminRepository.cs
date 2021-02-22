using DataLayer.Models.Admin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IAdminRepository : IDisposable
    {
        //Slider
        Task<IEnumerable<Slider>> GetAllSliders();
        bool AddPhoto(Slider sliderPhoto);
        IEnumerable<string> PhotoName();
        Slider GetSliderById(int id);
        bool EditSlider(Slider model);
        bool SliderExists(int id);
        Task<bool> DeleteSlider(int id);


        //Employee
        IEnumerable<Employee> GetAllEmployees();
        bool AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        bool EditEmployee(Employee model);
        bool EmployeeExists(int id);
        Task<bool> DeleteEmployee(int id);

        //OfficeInfo
        List<OfficeInfo> GetOfficeInfo();
        bool EditOfficeInfo(OfficeInfo model);
        OfficeInfo GetInfoById(int id);
        bool OfficeInfoExists(int id);

        //DescriptionText
        bool AddDescription(DescriptionTexts text);
        IEnumerable<DescriptionTexts> GetBodyTexts();
        IEnumerable<DescriptionTexts> GetThirdPartyTexts();
        IEnumerable<DescriptionTexts> GetLifeTexts();
        IEnumerable<DescriptionTexts> GetFireTexts();
        IEnumerable<DescriptionTexts> GetResponsibilityTexts();

        void save();

    }
}
