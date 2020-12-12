using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Ayoobifurniture.Core.DTOs;
using Ayoobifurniture.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ayoobifurniture.Web.Pages.Admin.Content
{
    [Authorize]

    public class CreateModel : PageModel
    {
        private IContentService _ContentService;

        public CreateModel(IContentService ContentService)
        {
            _ContentService = ContentService;
        }


        //[BindProperty]
        //public Item_ContentViewModel VM { get; set; }

        //public void OnGet()
        //{
        //   //ViewData["Contents"] = _ContentService.g();
        //}

        //public IActionResult OnPost(int SelectedParent, int optradio)
        //{
        //    ViewData["Contents"] = _ContentService.AddNewContent ();

        //    if (SelectedParent == 0)
        //    {

        //        return Page();
        //    }

            
        //    if (!ModelState.IsValid)
        //        return Page();


        //    // Save New Content in DB
        //    _ContentService.AddNewContent (VM);


        //    return Redirect("/Admin/Contents");

        //}
    }
}
