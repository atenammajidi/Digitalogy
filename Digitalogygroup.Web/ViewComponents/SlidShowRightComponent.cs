using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digitalogygroup.Web.ViewComponents
{
    [ViewComponent(Name = "SlidShowRightComponent")]
    public class SlidShowRightComponent : ViewComponent
    {
        private ISlidShowService _SlidShowService;

        public SlidShowRightComponent(ISlidShowService SlidShowService)
        {
            _SlidShowService = SlidShowService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int pa)
        {
            return await Task.FromResult((IViewComponentResult)View("SliderRight", _SlidShowService.GetSlidShow_Parent(pa)));
        }
    }
}
