using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Digitalogygroup.Web.ViewComponents
{
    [ViewComponent(Name = "SlidShowComponent")]
    public class SlidShowComponent:ViewComponent
    {
        private ISlidShowService _SlidShowService;

        public SlidShowComponent(ISlidShowService SlidShowService)
        {
            _SlidShowService = SlidShowService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int pa)
        {
            return await Task.FromResult((IViewComponentResult)View("SliderMain", _SlidShowService.GetSlidShow_Parent(pa)));
        }
    }
}
