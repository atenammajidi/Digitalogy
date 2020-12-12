using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digitalogygroup.Core.DTOs;
using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Digitalogygroup.Web.Pages.Admin.ManageUsers
{
    [Authorize]
    public class EditUserModel : PageModel
    {

        private IUserService _userService;
        private IPermissionService _permissionService;

        public EditUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }



        [BindProperty]
        public EditUserFromAdminViewModel VM { get; set; }


        public void OnGet(int id)
        {
            VM = _userService.GetUserForShowInEditMode(id);
            ViewData["Roles"] = _permissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            ViewData["Roles"] = _permissionService.GetRoles();

            if (SelectedRoles.Count() == 0)
            {
                return Page();
            }


            if (!ModelState.IsValid)
            {
                return Page();
            }

            _userService.EditUserFromAdmin(VM);

            //Edit Roles
            _permissionService.EditRolesUser(VM.UserId, SelectedRoles);
            return RedirectToPage("Index");
        }


    }
}