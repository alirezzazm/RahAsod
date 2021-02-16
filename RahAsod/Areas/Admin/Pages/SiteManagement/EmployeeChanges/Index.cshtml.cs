using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Models.Admin;

namespace RahAsod.Areas.Admin.Pages.SiteManagement.EmployeeChanges
{
    public class IndexModel : PageModel
    {
        private readonly DataLayer.Context.InsuranceContext _context;

        public IndexModel(DataLayer.Context.InsuranceContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }


        public async Task OnPostAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
