using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.DataLayer.Entities.User
{
    public class Tbl_Role
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = " عنوان نقش(انگلیسی)")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = " مقدار {0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string RoleTitleEn { get; set; }

        [Display(Name = "عنوان نقش(فارسی)")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = " مقدار {0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string RoleTitleFa { get; set; }


        public bool IsDelete { get; set; }
    }
}
