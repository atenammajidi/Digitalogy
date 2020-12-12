using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digitalogygroup.Web.ViewComponents
{
    [ViewComponent(Name = "SlidShowLeftComponent")]
    public class SlidShowLeftComponent : ViewComponent
    {
        private ISlidShowService _SlidShowService;

        public SlidShowLeftComponent(ISlidShowService SlidShowService)
        {
            _SlidShowService = SlidShowService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int pa)
        {
            return await Task.FromResult((IViewComponentResult)View("SliderLeft", _SlidShowService.GetSlidShow_Parent(pa)));
        }
    }
}
