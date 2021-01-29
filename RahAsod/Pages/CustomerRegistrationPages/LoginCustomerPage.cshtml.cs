using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RahAsod.Pages.CustomerRegistrationPages
{
    public class LoginCustomerPageModel : PageModel
    {

        private readonly SignInManager<RegisterCustomer> _signInManager;

        public LoginCustomerPageModel(SignInManager<RegisterCustomer> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("/MainPage/HomePage");
        }


        public IActionResult OnGet(string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToPage("/MainPage/HomePage");

            ViewData["ReturnUrl"] = returnUrl;
            return Page();
        }

        [BindProperty]
        public CustomerLogin Loginmodel { get; set; }
        public async Task<IActionResult> OnPost(string returnUrl = null)
        {

            if (_signInManager.IsSignedIn(User))
                return RedirectToPage("/MainPage/HomePage");
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(Loginmodel.NationalCode, Loginmodel.Password, false, true);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                    return RedirectToPage("/MainPage/HomePage");
                }
                if (result.IsLockedOut)
                {
                    ViewData["ErrorMessage"] = "حساب کاربری شما به دلیل 5 بار تلاش ناموفق بمدت 5دقیقه قفل شده است";
                    return Page();
                }

                ModelState.AddModelError("", "کد ملی یا رمز عبور اشتباه است");

            }

            return Page();

        }
    }
}
