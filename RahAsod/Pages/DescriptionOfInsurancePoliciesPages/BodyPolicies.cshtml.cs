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

namespace RahAsod.Pages.DescriptionOfInsurancePoliciesPages
{
    public class BodyPoliciesModel : PageModel
    {

        private readonly IAdminRepository AdminRepository;
        public BodyPoliciesModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
        }

        [BindProperty]
        public IEnumerable<DescriptionTexts> desText { get; set; }
        public IActionResult OnGet()
        {
          desText = AdminRepository.GetBodyTexts();
            return Page();
        }
    }
}
