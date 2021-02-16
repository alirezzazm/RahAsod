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
    public class DeleteModel : PageModel
    {
        private readonly DataLayer.Context.InsuranceContext _context;

        public DeleteModel(DataLayer.Context.InsuranceContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Slider Slider { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Slider = await _context.SliderPics.FirstOrDefaultAsync(m => m.Id == id);

            if (Slider == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Slider = await _context.SliderPics.FindAsync(id);

            if (Slider != null)
            {
                _context.SliderPics.Remove(Slider);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
