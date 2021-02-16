using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Models.Admin;

namespace RahAsod.Areas.Admin.Pages.SiteManagement.SliderPhoto
{
    public class IndexModel : PageModel
    {
        private readonly InsuranceContext _context;

        public IndexModel(InsuranceContext context)
        {
            _context = context;
        }

        public IList<Slider> Slider { get;set; }

        public async Task OnGetAsync()
        {
            Slider = await _context.SliderPics.ToListAsync();
        }
    }
}
