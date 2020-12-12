using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.Core.DTOs
{
    public class LoginViewModel
    {

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "نام کاربری را وارد کنید")]
        public string UserName { get; set; }


        [Display(Name = "پسورد")]
        [Required(ErrorMessage = "پسورد را وارد کنید")]
        public string password { get; set; }



        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
