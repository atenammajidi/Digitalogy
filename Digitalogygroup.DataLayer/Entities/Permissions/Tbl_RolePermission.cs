using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Digitalogygroup.DataLayer.Entities.User;

namespace Digitalogygroup.DataLayer.Entities.Permissions
{
   public class Tbl_RolePermission
    {
        [Key]
        public int Id { get; set; }
        public int FK_Role { get; set; }
        public int FK_Permission { get; set; }

      
    }
}
