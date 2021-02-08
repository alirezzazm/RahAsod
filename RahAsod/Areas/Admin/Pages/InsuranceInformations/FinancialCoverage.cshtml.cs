using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RahAsod.Areas.Admin.Pages.InsuranceInformations
{
    public class FinancialCoverageModel : PageModel
    {
        private readonly IThirdPartyRepository thirdpartyrepository;
        private readonly InsuranceContext _context;
        public FinancialCoverageModel(InsuranceContext context)
        {
            thirdpartyrepository = new ThirdPartyRespository(context);
            _context = context;
        }


        [BindProperty]
        public IEnumerable<CarFinancialCoverage> showfinancialCoverage { get; set; }
        public async Task<IActionResult> OnGet()
        {
            showfinancialCoverage = thirdpartyrepository.ShowFinancialCoverages();
            return Page();
        }

        [BindProperty]
        public CarFinancialCoverage addFinancialCoverage { get; set; }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                thirdpartyrepository.AddFinancialCoverage(addFinancialCoverage);
            }

        }
    }
}
