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
    public class CreateUserModel : PageModel
    {

        private IUserService _userService;
        private IPermissionService _permissionService;

        public CreateUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }



        [BindProperty]
        public CreateUserByAdminViewModel VM { get; set; }



        public void OnGet()
        {
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
                return Page();

            int userId = _userService.AddUserFromAdmin(VM);

            //Add Roles
            _permissionService.AddRolesToUser(SelectedRoles, userId);


            return Redirect("/Admin/ManageUsers");

        }

    }
}