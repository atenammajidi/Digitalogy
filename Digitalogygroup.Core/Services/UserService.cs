using Digitalogygroup.Core.Security;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.Core.DTOs;
using Digitalogygroup.DataLayer.Context;
using Digitalogygroup.DataLayer.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digitalogygroup.Core.Services
{
    public class UserService : IUserService
    {


        private DigitalogygroupContext _db;
        public UserService(DigitalogygroupContext d)
        {
            _db = d;
        }


        public int AddUser(Tbl_User newuser)
        {
            _db.Tbl_User.Add(newuser);
            _db.SaveChanges();
            return newuser.Id;
        }

        public int AddUserFromAdmin(CreateUserByAdminViewModel user)
        {
            Tbl_User addUser = new Tbl_User();
            addUser.password = PasswordHelper.EncodePasswordMd5(user.Password);
            addUser.IsActive = true;
            addUser.RegisterDate = DateTime.Now;
            addUser.username = user.UserName;
            addUser.FullName = user.FullName;
            return AddUser(addUser);
        }

        public void EditUserByAdmin(EditUserByAdminViewModel user)
        {


            Tbl_User s = _db.Tbl_User.Find(user.UserID);


            if (s.IsActive == true)
            {
                s.IsActive = false;
                _db.Tbl_User.Update(s);
                _db.SaveChanges();
            }

            else
            {

                s.IsActive = true;
                _db.Tbl_User.Update(s);
                _db.SaveChanges();
            }

        }

        public EditUserByAdminViewModel EditUserByAdmin(int UserID)
        {
            return _db.Tbl_User.Where(u => u.Id == UserID)
               .Select(u => new EditUserByAdminViewModel
               {
                   UserID = u.Id,
                   username = u.username,
                   FullName = u.FullName,
                   IsActive = u.IsActive,
               }).SingleOrDefault();
        }

        public EditUserByUserViewModel EditUserByUser(int UserID)
        {
            return _db.Tbl_User.Where(u => u.Id == UserID)
                .Select(u => new EditUserByUserViewModel
                {
                    UserID = u.Id,
                    username = u.username,
                    FullName = u.FullName,
                    password = u.password,
                }).SingleOrDefault();
        }

        public void EditUserByUser(EditUserByUserViewModel user)
        {

            Tbl_User s = _db.Tbl_User.Find(user.UserID);

            s.FullName = user.FullName;
            s.password = PasswordHelper.EncodePasswordMd5(user.password);
            _db.Tbl_User.Update(s);
            _db.SaveChanges();
        }

      

        public Tbl_User GetUserById(int userId)
        {
            return _db.Tbl_User.Find(userId);
        }

        public ManageUserForAdminViewModel GetAllUser(int pageId = 1, string filterUserName = "", string filterFullName = "")
        {
            IQueryable<Tbl_User> result = _db.Tbl_User;

            if (!string.IsNullOrEmpty(filterFullName))
            {
                result = result.Where(u => u.FullName.Contains(filterFullName));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(u => u.username.Contains(filterUserName));
            }

            int take = 10;
            int skip = (pageId - 1) * take;


            ManageUserForAdminViewModel myresult = new ManageUserForAdminViewModel();
            myresult.CurrentPage = pageId;
            myresult.PageCount = result.Count() / take;
            myresult.Tbl_Users = result.OrderBy(u => u.Id).Skip(skip).Take(take).ToList();
            return myresult;
        }

      

        public bool IsExistUserName(string username)
        {
            return _db.Tbl_User.Any(u => u.username == username);
        }

        public Tbl_User loginUser(LoginViewModel lvn)
        {
            string HashPass = PasswordHelper.EncodePasswordMd5(lvn.password);
            return _db.Tbl_User.SingleOrDefault(u => u.username == lvn.UserName && u.password == HashPass);
        }

        public EditUserFromAdminViewModel GetUserForShowInEditMode(int userId)
        {
            return _db.Tbl_User.Where(u => u.Id == userId)
               .Select(u => new EditUserFromAdminViewModel()
               {
                   UserId=u.Id,
                   FullName = u.FullName,
                   UserName = u.username,
                   MyUserRoles = _db.Tbl_UserRole.Where(r=> r.FK_User==userId).Select(r => r.FK_Role).ToList()
               }).Single();
        }

        public void EditUserFromAdmin(EditUserFromAdminViewModel editUser)
        {
            Tbl_User user = GetUserById(editUser.UserId);
            if (!string.IsNullOrEmpty(editUser.Password))
            {
                user.password = PasswordHelper.EncodePasswordMd5(editUser.Password);
            }
            if (!string.IsNullOrEmpty(editUser.FullName))
            {
                user.FullName = editUser.FullName;
            }


            _db.Tbl_User.Update(user);
            _db.SaveChanges();
        }

     
    }
}
