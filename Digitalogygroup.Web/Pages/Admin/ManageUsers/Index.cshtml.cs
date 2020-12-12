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
    public class IndexModel : PageModel
    {

        private IUserService _userservice;

        public IndexModel(IUserService userService)
        {
            _userservice = userService;
        }


        public ManageUserForAdminViewModel VM { get; set; }

     

        public void OnGet(int pageId = 1, string filterUserName = "", string filterFullName = "")
        {
            VM = _userservice.GetAllUser(pageId, filterUserName, filterFullName);
        }
    }
}