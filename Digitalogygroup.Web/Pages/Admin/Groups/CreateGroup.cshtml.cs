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
    public class CreateGroupModel : PageModel
    {

        private IGroupService _GroupService;

        public CreateGroupModel(IGroupService GroupService)
        {
            _GroupService = GroupService;
        }


        [BindProperty]
        public AddNewGroupViewModel VM { get; set; }

        public void OnGet()
        {
            ViewData["Groups"] = _GroupService.GetProductGroup();
        }

        public IActionResult OnPost(int SelectedParent , int optradio)
        {
            ViewData["Groups"] = _GroupService.GetProductGroup();

            if (SelectedParent == 0)
            {

                return Page();
            }

            if (optradio == 1)
            {
                VM.IsActive = true;
            }
            else
            {
                VM.IsActive = false;
            }


            VM.FK_Parent = SelectedParent.ToString();

            if (!ModelState.IsValid)
                return Page();


            // Save New Group in DB
            _GroupService.AddNewGroupInDB(VM);




            return Redirect("/Admin/Groups");

        }
    }
}