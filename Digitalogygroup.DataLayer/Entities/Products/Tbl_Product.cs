using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.DataLayer.Entities.Products
{
   public class Tbl_Product
    {

        [Key]
        public int Id { get; set; }


        public int FK_ProductGroup { get; set; }


        public int FK_Language { get; set; }


        [Display(Name = "عنوان محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = " مقدار {0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string ProductTitle { get; set; }


        [Display(Name = "توضیح کوتاه محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        public string ProductShortDesc { get; set; }



        [Display(Name = "شرح کامل محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        public string ProductFullDesc { get; set; }


        public bool IsActive { get; set; }


        public DateTime RegisterDate { get; set; }

        [Display(Name = "عکس")]
        public string  ProductImg { get; set; }
    }
}
