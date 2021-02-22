using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Models.Admin;
using DataLayer.Repositories;
using DataLayer.Services;

namespace RahAsod.Areas.Admin.Pages.SiteManagement.EmployeeChanges
{
    public class IndexModel : PageModel
    {
        private readonly IAdminRepository AdminRepository;
        public IndexModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
        }


        public IEnumerable<Employee> employee { get;set; }

        public IActionResult OnGet()
        {
            employee = AdminRepository.GetAllEmployees();
            return Page();
        }

        [BindProperty]
        public int employeeId { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            await AdminRepository.DeleteEmployee(employeeId);
            AdminRepository.save();
            return RedirectToPage("./Index");
        }
    }
}
