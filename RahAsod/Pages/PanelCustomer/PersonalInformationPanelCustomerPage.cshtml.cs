using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataLayer.Models;

namespace RahAsod.Pages.PanelCustomer
{
    public class PersonalInformationPanelCustomerPageModel : PageModel
    {
        private readonly DataLayer.Context.InsuranceContext _context;

        public PersonalInformationPanelCustomerPageModel(DataLayer.Context.InsuranceContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public RegisterCustomer RegisterCustomer { get; set; }

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
