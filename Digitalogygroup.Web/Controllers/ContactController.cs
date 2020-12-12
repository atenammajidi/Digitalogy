using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Digitalogygroup.Web.Controllers
{
    public class ContactController : Controller
    {
        private IContentService _Contentservice;
        public ContactController(IContentService c)
        {
            _Contentservice = c;
        }
        public IActionResult Index()
        {
            ViewData["ccc"] = _Contentservice.GetSelectContent(7).Content;
            return View(ViewData["ccc"]);
        }
    }
}