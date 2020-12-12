using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;


namespace Digitalogygroup.Core.DTOs
{
   public class GroupsViewModel
    {

        public class AddNewGroupViewModel
        {

            [Display(Name = "عنوان گروه")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
            public string GroupTitle { get; set; }


            public string FK_Parent { get; set; }


            [Display(Name = "اولویت")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public string priority { get; set; }



            [Display(Name = "وضعیت")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public bool IsActive { get; set; }



        }

        public class EditGroupViewModel
        {


            public int GroupID { get; set; }

            [Display(Name = "عنوان گروه")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
            public string GroupTitle { get; set; }


            public string FK_Parent { get; set; }


            [Display(Name = "اولویت")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public string priority { get; set; }



            [Display(Name = "وضعیت")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

            public bool IsActive { get; set; }

        }


        public class AllProductList
        {


            public int ProdID { get; set; }


            [Display(Name = "نام محصول")]
            public string ProductTitle { get; set; }

            [Display(Name = "نام سرگروه")]
            public string GroupTitle { get; set; }


            [Display(Name = "زبان")]
            public string Language { get; set; }




            [Display(Name = "شرح کوتاه محصول")]
            public string ProdShortDesc { get; set; }


            [Display(Name = "وضعیت")]
            public bool IsActive { get; set; }



            [Display(Name = "تاریخ ثبت")]
            public DateTime RegisterDate { get; set; }

        }


        public class AddNewProductViewModel
        {

            [Display(Name = "عنوان محصول")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
            public string ProductTitle { get; set; }


            public string FK_Group { get; set; }

            public string FK_Language { get; set; }


            [Display(Name = "شرح کوتاه محصول")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public string ProdShortDesc { get; set; }


            [Display(Name = "شرح بلند محصول")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public string ProdFullDesc { get; set; }



            [Display(Name = "وضعیت")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public bool IsActive { get; set; }



            public IFormFile pic { get; set; }



        }


        public class EditProductViewModel
        {

            public int ProdID { get; set; }


            [Display(Name = "عنوان محصول")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
            public string ProductTitle { get; set; }


            public int FK_Group { get; set; }

            public string FK_Language { get; set; }


            [Display(Name = "شرح کوتاه محصول")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public string ProdShortDesc { get; set; }


            [Display(Name = "شرح بلند محصول")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public string ProdFullDesc { get; set; }



            [Display(Name = "وضعیت")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public bool IsActive { get; set; }



            public IFormFile pic { get; set; }


            public string picName { get; set; }

        }


    }
}
