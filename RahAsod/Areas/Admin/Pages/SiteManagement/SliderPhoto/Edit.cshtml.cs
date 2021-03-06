﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Models.Admin;
using DataLayer.Repositories;
using DataLayer.Services;

namespace RahAsod.Areas.Admin.Pages.SiteManagement.SliderPhoto
{
    public class EditModel : PageModel
    {
        private readonly IAdminRepository AdminRepository;
        public EditModel(InsuranceContext context)
        {
            AdminRepository = new AdminRepository(context);
        }

        [BindProperty]
        public Slider model { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            model = AdminRepository.GetSliderById(id.Value);

            if (model == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            AdminRepository.EditSlider(model);


            try
            {
                AdminRepository.save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminRepository.SliderExists(model.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }


    }
}
