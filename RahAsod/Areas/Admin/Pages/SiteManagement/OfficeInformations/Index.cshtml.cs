using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Models.Admin;
using DataLayer.Repositories;
using DataLayer.Services;

namespace RahAsod.Areas.Admin.Pages.SiteManagement.OfficeInformations
{
    public class IndexModel : PageModel
    {
        private readonly IAdminRepository AdminRepository;
        public IndexModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
        }

        public IList<OfficeInfo> info { get;set; }

        public void OnGet()
        {
            info = AdminRepository.GetOfficeInfo();
        }
    }
}
