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

namespace RahAsod.Areas.Admin.Pages.InsuranceInformations
{
    public class vehiclesModel : PageModel
    {
        private readonly IThirdPartyRepository thirdPartyRepository;
    
        
        public vehiclesModel(InsuranceContext context)
        {
            thirdPartyRepository = new ThirdPartyRespository(context);
        }


        public IEnumerable<Car> cars { get; set; }
        public void OnGet()
        {
           cars = thirdPartyRepository.ShowAllCars();
        }

        public void OnPost()
        {

        }
    }
}
