using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Digitalogygroup.Core.DTOs;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Entities.User;
using Digitalogygroup.Core.Security;
using Microsoft.AspNetCore.Authorization;

namespace Digitalogygroup.Web.Pages.Admin.Roles
{

    [Authorize]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;

        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public List<Tbl_Role> RolesList { get; set; }


        public void OnGet()
        {
            RolesList = _permissionService.GetRoles();
        }

       
    }
}