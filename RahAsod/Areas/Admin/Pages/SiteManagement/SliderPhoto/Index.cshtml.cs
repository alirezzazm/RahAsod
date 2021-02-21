using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Models.Admin;
using DataLayer.Services;
using DataLayer.Repositories;

namespace RahAsod.Areas.Admin.Pages.SiteManagement.SliderPhoto
{
    public class IndexModel : PageModel
    {
        private readonly IAdminRepository AdminRepository;
        private readonly InsuranceContext _context;
        public IndexModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
            _context = context;
        }

        [BindProperty]
        public IEnumerable<Slider> slider { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            slider = await AdminRepository.GetAllSliders();
            return Page();
        }

        [BindProperty]
        public int sliderId { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            await AdminRepository.DeleteSlider(sliderId);
            AdminRepository.save();
            return RedirectToPage("./Index");
        }
    }
}
