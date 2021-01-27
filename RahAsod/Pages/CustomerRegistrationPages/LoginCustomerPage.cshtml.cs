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

        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginCustomerPageModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Logout()
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

        public async Task<IActionResult> OnPost(CustomerLogin model, string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToPage("/MainPage/HomePage");
            ViewData["ReturnUrl"] = returnUrl;

            var result = await _signInManager.PasswordSignInAsync(model.NationalCode, model.Password, true,true);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);

            }
            if (result.IsLockedOut)
            {
                ViewData["ErrorMessage"] = "حساب کاربری شما به دلیل 5 بار تلاش ناموفق بمدت 5دقیقه قفل شده است";
                return Page();
            }
            else
            {
                ModelState.AddModelError("", "شماره موبایل یا رمز عبور اشتباه است");
                return Page();
            }


        }
    }
}
