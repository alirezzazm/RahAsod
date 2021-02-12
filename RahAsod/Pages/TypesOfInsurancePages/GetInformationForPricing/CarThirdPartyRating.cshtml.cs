using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models.Descriptions;
using DataLayer.Repositories;
using DataLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RahAsod.Pages.TypesOfInsurancePages.GetInformationForRating
{
    public class CarThirdPartyRatingModel : PageModel
    {


        private readonly IThirdPartyRepository thirdPartyRepository;
        public CarThirdPartyRatingModel(InsuranceContext context)
        {
            thirdPartyRepository = new ThirdPartyRespository(context);
        }



        public IEnumerable<string> carNames { get; set; }
        public void OnGet()
        {
            carNames = thirdPartyRepository.ShowCarNames();
        }

        [BindProperty]
        public DescriptionOfThirdPartyInsurance thirdParty { get; set; }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }




            return RedirectToPage("./Index");
        }
    }
}
