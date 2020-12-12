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
    public class EditModel : PageModel
    {
        private ISlidShowService _SlidShowService;

        public EditModel(ISlidShowService SlidShowService)
        {
            _SlidShowService = SlidShowService;
        }


        [BindProperty]
        public Item_SlideShowViewModel VM { get; set; }

        public void OnGet(int id)
        {
            VM = _SlidShowService.GetSelectSlidShow(id);
        }
        public IActionResult OnPost(int optradio)
        {
            _SlidShowService.EditNewSlidShow(VM);
            return Redirect("/Admin/SlidShow");
        }

    }
}
