using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digitalogygroup.Core.DTOs;
using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Digitalogygroup.Web.Pages.Admin.Content
{
    [Authorize]
    public class EditModel : PageModel
    {
        private IContentService _ContentService;

        public EditModel(IContentService ContentService)
        {
            _ContentService = ContentService;
        }



        [BindProperty]
        public Item_ContentViewModel VM { get; set; }

        public void OnGet(int id)
        {
            VM = _ContentService .GetSelectContent(id); 
        }
        public IActionResult OnPost(int optradio)
        {
 

            _ContentService .EditNewContent(VM);


            return Redirect("/Admin/Content");
        }

    }
}
