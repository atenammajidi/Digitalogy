using Digitalogygroup.DataLayer.Entities.User;
using Digitalogygroup.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalogygroup.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistUserName(string username);

        int AddUser(Tbl_User newuser);

     

        void EditUserByAdmin(EditUserByAdminViewModel user);


        EditUserByAdminViewModel EditUserByAdmin(int UserID);


        EditUserByUserViewModel EditUserByUser(int UserID);


        void EditUserByUser(EditUserByUserViewModel user);


        Tbl_User loginUser(LoginViewModel UserLogin);

        Tbl_User GetUserById(int userId);


        #region AdminPanel
        ManageUserForAdminViewModel GetAllUser(int pageId = 1, string filterUserName = "", string filterFullName = "");
        int AddUserFromAdmin(CreateUserByAdminViewModel user);

        EditUserFromAdminViewModel GetUserForShowInEditMode(int userId);
        void EditUserFromAdmin(EditUserFromAdminViewModel editUser);


        #endregion

    }
}
