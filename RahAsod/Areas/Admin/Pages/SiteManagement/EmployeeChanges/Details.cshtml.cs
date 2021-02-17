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
    public class DetailsModel : PageModel
    {
        private readonly IAdminRepository AdminRepository;
        public DetailsModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
        }

        public Employee employee { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            employee = AdminRepository.GetEmployeeById(id.Value);

            if (employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
