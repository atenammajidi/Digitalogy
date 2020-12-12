using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Digitalogygroup.DataLayer.Entities.User
{
   public class Tbl_UserRole
    {

        [Key]
        public int Id { get; set; }

        public int FK_Role { get; set; }

        public int FK_User { get; set; }
    }
}
