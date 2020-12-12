using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.DataLayer.Entities.Products
{
  public class Tbl_ProductGroup
    {
        [Key]
        public int Id { get; set; }

        public int? FK_Parent { get; set; }

        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = " مقدار {0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string GroupTitle { get; set; }

        [Display(Name = "اولویت گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        public int priority { get; set; }


        public bool IsActive { get; set; }


    }
}
