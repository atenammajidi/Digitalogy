using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digitalogygroup.Web.ViewComponents
{
    public class MenuComponent : ViewComponent
    {
        private IGroupService _GroupService;

        public MenuComponent(IGroupService GroupService)
        {
            _GroupService = GroupService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("MenuGroup", _GroupService .ShowAllProduct()));
        }
    }
}
