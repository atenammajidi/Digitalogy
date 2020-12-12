using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.DataLayer.Entities.User
{
    public class Tbl_User
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = " مقدار {0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string username { get; set; }


        [Display(Name = "پسورد")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = " مقدار {0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string password { get; set; }

        public bool IsActive { get; set; }


        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = " مقدار {0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string FullName { get; set; }

        public DateTime RegisterDate { get; set; }


    }
}
