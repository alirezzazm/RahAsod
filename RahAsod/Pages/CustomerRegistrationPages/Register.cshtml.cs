using System;
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

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RegisterCustomer RegisterCustomer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost(RegisterCustomer model)
        {
            if (ModelState.IsValid)
            {
                var user = new RegisterCustomer()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CustomerNationalCode = model.CustomerNationalCode,
                    PhoneNumber = model.PhoneNumber,
                    HomeNumber = model.HomeNumber,
                    Email = model.Email,
                    Address = model.Address,
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
            }
            return Page();


        }
    }
}
