using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Entities.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Digitalogygroup.Web.Pages.Admin.Groups
{

    [Authorize]
    public class IndexModel : PageModel
    {

        private IGroupService _GroupService;

        public IndexModel(IGroupService groupService)
        {
            _GroupService = groupService;
        }


        public List<Tbl_ProductGroup> ProductGroupList { get; set; }

        public void OnGet()
        {
            ProductGroupList = _GroupService.GetProductGroup();
        }
    }
}