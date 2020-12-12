using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Digitalogygroup.Web.Controllers
{
    public class AboutController : Controller
    {
        private  IContentService _Contentservice;
        public AboutController(IContentService c)
        {
            _Contentservice = c;
        }
        // GET: About
        public ActionResult Index(int cid=1)
        {
            //ViewData["ccc"]=  _Contentservice.GetSelectContent(cid).Content;
            return View(_Contentservice.GetSelectContent(cid));
        }
         
        public ActionResult team() 
        {
            ViewData["ccc"] = _Contentservice.GetSelectContent(5).Content;
            return View(ViewData["ccc"]);
        }
        public ActionResult vision()
        {
            ViewData["ccc"] = _Contentservice.GetSelectContent(4).Content;
            return View(ViewData["ccc"]);
        }
        public ActionResult Customers() 
        {
            ViewData["ccc"] = _Contentservice.GetSelectContent(6).Content;
            return View(ViewData["ccc"]);
        }
        

    }
}