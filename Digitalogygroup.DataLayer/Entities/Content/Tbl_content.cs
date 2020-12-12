using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.DataLayer.Entities.Content
{
  public  class Tbl_content
    {
        [Key]
        public int Id { get; set; } 
        public string Header { get; set; }
        public string  Title { get; set; }
        public string  Content { get; set; } 


    }
}
