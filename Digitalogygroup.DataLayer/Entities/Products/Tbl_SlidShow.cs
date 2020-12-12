using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.DataLayer.Entities.Products
{
  public class Tbl_SlidShow
    {
        [Key]
        public int Id { get; set; }
        public int Parent { get; set; }
        public string  Title { get; set; }
        public string  ImageUrl { get; set; }   
        public string  Link { get; set; } 
    }
}
