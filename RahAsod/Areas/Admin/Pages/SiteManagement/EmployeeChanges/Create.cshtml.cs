using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer.Context;
using DataLayer.Models.Admin;
using DataLayer.Repositories;
using DataLayer.Services;

namespace RahAsod.Areas.Admin.Pages.SiteManagement.EmployeeChanges
{
    public class CreateModel : PageModel
    {
        private readonly IAdminRepository AdminRepository;
        public CreateModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee employee { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            AdminRepository.AddEmployee(employee);
            AdminRepository.save();

            return RedirectToPage("./Index");
        }
    }
}
