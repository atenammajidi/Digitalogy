using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Digitalogygroup.Core.DTOs;
using Digitalogygroup.Core.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Digitalogygroup.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userservice;
        public AccountController(IUserService u)
        {
            _userservice = u;
        }


        #region Login

        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {

            if (!ModelState.IsValid)
            {
                return View(login);
            }


            var myuser = _userservice.loginUser(login);

            if (myuser != null)
            {
                if (myuser.IsActive == true)
                {

                    var myclaim = new List<Claim>() {

                    new Claim(ClaimTypes.NameIdentifier, myuser.Id.ToString()),
                    new Claim(ClaimTypes.Name, myuser.FullName.ToString())

                };

                    var myIdentity = new ClaimsIdentity(myclaim, CookieAuthenticationDefaults.AuthenticationScheme);
                    var myprinciple = new ClaimsPrincipal(myIdentity);
                    var myproperties = new AuthenticationProperties
                    {
                        IsPersistent = login.RememberMe
                    };

                    HttpContext.SignInAsync(myprinciple, myproperties);

                    ViewBag.IsSuccess = true;
                    return View();

                }

                else
                {
                    ModelState.AddModelError("UserName", "حساب کاربری غیرفعال است.");
                    return View();
                }

            }

            ModelState.AddModelError("UserName", "کاربری با این مشخصات یافت نشد.");
            return View();
        }



        #endregion

        #region logout
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }
        #endregion
    }
}