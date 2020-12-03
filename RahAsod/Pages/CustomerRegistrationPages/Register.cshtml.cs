using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer.Context;
using DataLayer.Models;

namespace RahAsod.Pages.CustomerRegistrationPages
{
    public class RegisterModel : PageModel
    {
        private readonly DataLayer.Context.InsuranceContext _context;

        public RegisterModel(DataLayer.Context.InsuranceContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RegisterCustomer RegisterCustomer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CustomerRegisteration.Add(RegisterCustomer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
