using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Models.Descriptions;

namespace RahAsod.Pages.TypesOfInsurancePages
{
    public class CarThirdPartyInsuranceModel : PageModel
    {
      

        public IActionResult OnGet()
        {
            return Page();
        }

        
    }
}
