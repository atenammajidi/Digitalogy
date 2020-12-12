using Digitalogygroup.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalogygroup.Core.DTOs
{
    public class ShowAllUserViewModel
    {

        public List<Tbl_User> Tbl_User { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }


      


    }

    public class EditUserByAdminViewModel
    {
        public int UserID { get; set; }

        public string FullName { get; set; }
        public string username { get; set; }

        public bool IsActive { get; set; }



    }

    public class EditUserByUserViewModel
    {
        public int UserID { get; set; }

        public string FullName { get; set; }
        public string username { get; set; }

        public string password { get; set; }



    }
}
