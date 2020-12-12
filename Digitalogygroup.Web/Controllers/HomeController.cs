using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Digitalogygroup.Web.Controllers
{
    public class HomeController : Controller
    { 
        private IContentService _ContentService;

        public HomeController(  IContentService ContentService)
        {
             _ContentService = ContentService;
        }
        public IActionResult Index(int cid=3)
        {
            return View(_ContentService.GetSelectContent(cid));
        }
    }
}