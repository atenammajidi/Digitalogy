using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Entities.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Digitalogygroup.Web.Pages.Admin.SlidShow
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private ISlidShowService _SlidShowService;

        public IndexModel(ISlidShowService SlidShowService)
        {
            _SlidShowService = SlidShowService;
        }
        public List<Tbl_SlidShow> SlidShowList { get; set; }

        public void OnGet()
        {
            SlidShowList = _SlidShowService.GetAllSlidShow();
        }
    }
    }
