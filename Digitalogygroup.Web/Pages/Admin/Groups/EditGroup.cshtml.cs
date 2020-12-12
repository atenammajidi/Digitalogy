using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Digitalogygroup.Core.DTOs.GroupsViewModel;

namespace Digitalogygroup.Web.Pages.Admin.Groups
{
    [Authorize]
    public class EditGroupModel : PageModel
    {

        private IGroupService _GroupService;

        public EditGroupModel(IGroupService GroupService)
        {
            _GroupService = GroupService;
        }



        [BindProperty]
        public EditGroupViewModel VM { get; set; }

        [BindProperty]
        public int EditIsActive { get; set; }

        public void OnGet(int id)
        {
            VM = _GroupService.ShowGroupForEditMode(id);

            if (VM.IsActive == true)
            {
                EditIsActive = 1;
            }
            else
            {
                EditIsActive = 0;
            }

            ViewData["Groups"] = _GroupService.GetProductGroup();
        }

        public IActionResult OnPost(int optradio)
        {

            ViewData["Groups"] = _GroupService.GetProductGroup();

            if (!ModelState.IsValid)
                return Page();

            if (optradio == 1)
            {
                VM.IsActive = true;
            }
            else
            {
                VM.IsActive = false;
            }

            _GroupService.UpdateGroup(VM);


            return Redirect("/Admin/Groups");
        }

    }
}