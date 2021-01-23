using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RahAsod.Pages.TypesOfInsurancePages.Issued
{
    public class CarThirdPartyIssuedModel : PageModel
    {
        private readonly DataLayer.Context.InsuranceContext _context;
        //public CarThirdPartyInsuranceModel(DataLayer.Context.InsuranceContext context)
        //{
        //    _context = context;
        //}
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DescriptionOfThirdPartyInsurance DescriptionOfThirdPartyInsurance { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ThirdPartyInsurance.Add(DescriptionOfThirdPartyInsurance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
