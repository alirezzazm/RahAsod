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

namespace RahAsod.Areas.Admin.Pages.InsurancesDescription
{
    public class BodyDescriptionModel : PageModel
    {
        private readonly IAdminRepository AdminRepository;

        public BodyDescriptionModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
        }

   
        public IActionResult OnGet()
        {
            //model = AdminRepository.GetBodyTexts().FirstOrDefault();
            return Page();
        }

        [BindProperty]
        public DescriptionTexts model { get; set; }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                AdminRepository.AddDescription(model);
                AdminRepository.save();

            }
            return Page();
        }
    }
}
