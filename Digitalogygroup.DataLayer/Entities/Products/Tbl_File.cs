using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.DataLayer.Entities.Products
{
    public class Tbl_File
    {

        [Key]
        public int Id { get; set; }

        public int FK_Group { get; set; }

        public int? FK_Product { get; set; }
      
        [Display(Name = "عکس")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
        public string image { get; set; }

    }
}
