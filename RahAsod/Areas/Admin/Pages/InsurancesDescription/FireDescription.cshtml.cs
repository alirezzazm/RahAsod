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
    public class FireDescriptionModel : PageModel
    {
        private readonly IAdminRepository AdminRepository;

        public FireDescriptionModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
        }

       
        public IActionResult OnGet()
        {
          
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
