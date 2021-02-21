using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer.Context;
using DataLayer.Models.Admin;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using DataLayer.Repositories;
using DataLayer.Services;

namespace RahAsod.Areas.Admin.Pages.SiteManagement.SliderPhoto
{
    public class CreateModel : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnv;
        private readonly IAdminRepository AdminRepository;
        public CreateModel(InsuranceContext context, IWebHostEnvironment webHostEnv)
        {
            _webHostEnv = webHostEnv;
            AdminRepository = new AdminRepository(context);
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Slider model { get; set; }
        public IFormFile formFile { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                string imgExtention = Path.GetExtension(formFile.FileName);
                if (imgExtention == ".jpg" || imgExtention == ".png" || imgExtention == ".jpeg")
                {
                    string fileName = Guid.NewGuid() + "-" + formFile.FileName;
                    var saveImagePath = Path.Combine(_webHostEnv.WebRootPath, "img", "Slider",fileName);
                    var stream = new FileStream(saveImagePath, FileMode.Create);
                    await formFile.CopyToAsync(stream);
                    var newPhoto = new Slider()
                    {
                        picPath = saveImagePath,
                        show = model.show,
                        picName = formFile.FileName
                    };
                    AdminRepository.AddPhoto(newPhoto);
                    AdminRepository.save();                   
                }
                else
                {
                    ModelState.AddModelError("photoUpload", "فایل ورودی باید یکی از فرمت های png jpg jpeg باشد");
                    return Page();
                }
            }


            return RedirectToPage("./Index");
        }
    }
}
