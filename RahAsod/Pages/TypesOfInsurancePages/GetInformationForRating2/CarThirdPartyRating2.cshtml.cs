using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models.Descriptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RahAsod.Pages.TypesOfInsurancePages.GetInformationForRating2
{
    public class CarThirdPartyRating2Model : PageModel
    {

        private readonly DataLayer.Context.InsuranceContext _context;
        public CarThirdPartyRating2Model(DataLayer.Context.InsuranceContext context)
        {
            _context = context;

        }

        public IActionResult OnGet()
        {
            //if (!HttpContext.User.Identity.IsAuthenticated)
            //{
            //    return Redirect("/CustomerRegistrationPages/LoginCustomerPage");
            //}
            //else
            //{
            return Page();
            //}
        }

        [BindProperty]
        public DescriptionOfThirdPartyInsurance DescriptionOfThirdPartyInsurance { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
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
