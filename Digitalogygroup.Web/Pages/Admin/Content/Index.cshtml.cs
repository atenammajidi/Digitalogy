using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Entities.Content;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Digitalogygroup.Web.Pages.Admin.Content
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private IContentService _ContentService;

        public IndexModel(IContentService ContentService)
        {
            _ContentService = ContentService;
        }
        public List<Tbl_content> ContentList  { get; set; }

        public void OnGet()
        {
            ContentList = _ContentService .GetAllContent ();
        }
    }
}
