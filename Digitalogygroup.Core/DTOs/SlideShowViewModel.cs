using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalogygroup.Core.DTOs
{
   public  class SlideShowViewModel
    {
    }
    public class ADDItem_SlideShowViewModel
    {
       
        public int Parent { get; set; }
        public string Title { get; set; }
        public IFormFile ImageUrl { get; set; } 
        public string Link { get; set; }

    }
    public class Item_SlideShowViewModel
    {
        public int Id { get; set; }
        public int Parent { get; set; }
        public string Title { get; set; }
        public IFormFile ImageUrl { get; set; }
        public string picName { get; set; }
        public string Link { get; set; }

    }
}
