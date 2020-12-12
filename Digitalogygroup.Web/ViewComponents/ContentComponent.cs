using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digitalogygroup.Web.ViewComponents
{
    [ViewComponent(Name = "ContentComponent")]
    public class ContentComponent : ViewComponent
    {
        private IContentService _ContentService;

        public ContentComponent(IContentService ContentService)
        {
            _ContentService = ContentService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int cid)
        {
            return await Task.FromResult((IViewComponentResult)View("ContentWithID", _ContentService.GetSelectContent(cid)));
        }
    }
    }
