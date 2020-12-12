using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.DataLayer.Entities.Products
{
   public class Tbl_Language
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "زبان")]
        public string LanguageTitle { get; set; }


    }
}
