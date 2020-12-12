using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Digitalogygroup.Core.DTOs.GroupsViewModel;

namespace Digitalogygroup.Web.Pages.Admin.Products
{
    [Authorize]
    public class CreateProductModel : PageModel
    {
        private IGroupService _GroupService;

        public CreateProductModel(IGroupService GroupService)
        {
            _GroupService = GroupService;
        }



        [BindProperty]
        public AddNewProductViewModel VM { get; set; }

        public void OnGet()
        {
            ViewData["Groups"] = _GroupService.GetActiveProductGroup();
        }


        public IActionResult OnPost(int SelectedParent, int optradio ,int rbtLan)
        {
            ViewData["Groups"] = _GroupService.GetActiveProductGroup();

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

            VM.FK_Language = rbtLan.ToString();

            VM.FK_Group = SelectedParent.ToString();

            if (!ModelState.IsValid)
                return Page();


            // Save New Group in DB
            _GroupService.AddNewProductInDB(VM);




            return Redirect("/Admin/Products");

        }
    }
}