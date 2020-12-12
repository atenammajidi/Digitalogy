using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Entities.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Digitalogygroup.Core.DTOs.GroupsViewModel;

namespace Digitalogygroup.Web.Pages.Admin.Products
{

    [Authorize]
    public class IndexModel : PageModel
    {

        private IGroupService _GroupService;

        public IndexModel(IGroupService groupService)
        {
            _GroupService = groupService;
        }



        public List<AllProductList> VM { get; set; }


        public void OnGet()
        {
            VM = _GroupService.ShowAllProduct();
        }


    }
}