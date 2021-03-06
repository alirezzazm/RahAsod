﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer.Context;
using DataLayer.Models;
using Microsoft.AspNetCore.Identity;

namespace RahAsod.Pages.CustomerRegistrationPages
{
    public class RegisterModel : PageModel
    {

        private readonly UserManager<RegisterCustomer> _userManager;
        private readonly SignInManager<RegisterCustomer> _signInManager;

        public RegisterModel(UserManager<RegisterCustomer> userManager, SignInManager<RegisterCustomer> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [BindProperty]
        public RegisterCustomer model { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }



        public async Task<IActionResult> OnPost()
        {
            //if (ModelState.IsValid)
            //{

                var user = new RegisterCustomer()
                {
                    Id = model.CustomerNationalCode,
                    UserName = model.CustomerNationalCode,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    HomeNumber = model.HomeNumber,
                    Email = model.Email,
                    Address = model.Address,
                    CustomerBirthday = model.CustomerBirthday,
                    CustomerType = model.CustomerType,
                    CustomerEconomicCode = model.CustomerEconomicCode
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: true);
                    return RedirectToPage("/MainPage/HomePage");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            //}

            return Page();


        }
    }
}
