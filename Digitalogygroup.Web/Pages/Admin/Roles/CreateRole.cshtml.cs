using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Entities.User;
using Microsoft.AspNetCore.Authorization;

namespace Digitalogygroup.Web.Pages.Admin.Roles
{
    [Authorize]
    public class CreateRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public CreateRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        
        [BindProperty]
        public Tbl_Role Role { get; set; }

        public void OnGet()
        {
            ViewData["Permissions"] = _permissionService.GetAllPermission();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();


            Role.IsDelete = false;
            int roleId = _permissionService.AddRole(Role);

            //TODO Add Permission

            return RedirectToPage("Index");
        }
    }
}