using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Digitalogygroup.Core.DTOs;
using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Digitalogygroup.Web.Pages.Admin.SlidShow
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private ISlidShowService _SlidShowService;

        public CreateModel(ISlidShowService SlidShowService)
        {
            _SlidShowService = SlidShowService;
        }

        [BindProperty]
        public ADDItem_SlideShowViewModel  VM { get; set; }

        //public void OnGet()
        //{
        //    ViewData["SlidShows"] = _SlidShowService.GetActiveProductSlidShow();
        //}


        public IActionResult OnPost()
        { 
            if (!ModelState.IsValid)
                return Page();
             
            _SlidShowService.AddNewSlidShow(VM);

            return Redirect("/Admin/SlidShow");

        }
    }
}
