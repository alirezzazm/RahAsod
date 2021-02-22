using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models.Admin;
using DataLayer.Repositories;
using DataLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RahAsod.Pages.MainPage
{
    public class HomePageModel : PageModel
    {

        private readonly IAdminRepository AdminRepository;
        public HomePageModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
        }

        public IEnumerable<OfficeInfo> officeInfos { get; set; }
        public IEnumerable<string> pics { get; set; }
        public IEnumerable<Employee> employees { get; set; }
        public void OnGet()
        {
            pics = AdminRepository.PhotoName();
            officeInfos = AdminRepository.GetOfficeInfo();
            employees = AdminRepository.GetAllEmployees();
        }
    }
}
