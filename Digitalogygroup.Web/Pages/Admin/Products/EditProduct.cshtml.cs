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
    public class EditProductModel : PageModel
    {
        private IGroupService _GroupService;

        public EditProductModel(IGroupService GroupService)
        {
            _GroupService = GroupService;
        }




        [BindProperty]
        public EditProductViewModel VM { get; set; }

        [BindProperty]
        public int EditIsActive { get; set; }





        public void OnGet(int id)
        {
            VM = _GroupService.ShowProductForEditMode(id);

            if (VM.IsActive == true)
            {
                EditIsActive = 1;
            }
            else
            {
                EditIsActive = 0;
            }

            ViewData["Groups"] = _GroupService.GetActiveProductGroup();

        }


        public IActionResult OnPost(int SelectedParent, int optradio)
        {

            ViewData["Groups"] = _GroupService.GetActiveProductGroup();

            VM.FK_Group = SelectedParent;

        
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

            _GroupService.UpdateProduct(VM);

            return Redirect("/Admin/Products");



        }
    }
}