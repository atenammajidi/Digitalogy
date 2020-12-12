using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Digitalogygroup.Core.Services.Interfaces;
using Digitalogygroup.DataLayer.Context;
using Digitalogygroup.DataLayer.Entities.Permissions;
using Digitalogygroup.DataLayer.Entities.User;

namespace Digitalogygroup.Core.Services
{
    public class PermissionService:IPermissionService
    {
        private DigitalogygroupContext _context;

        public PermissionService(DigitalogygroupContext context)
        {
            _context = context;
        }
        public List<Tbl_Role> GetRoles()
        {
            return _context.Tbl_Role.ToList();
        }

        public void AddRolesToUser(List<int> roleIds, int userId)
        {
            foreach (int roleId in roleIds)
            {
                _context.Tbl_UserRole.Add(new Tbl_UserRole()
                {
                    FK_Role = roleId,
                    FK_User = userId
                });
            }

            _context.SaveChanges();
        }

       

        public void EditRolesUser(int userId, List<int> rolesId)
        {
            //Delete All Roles User
            _context.Tbl_UserRole.Where(r => r.FK_User == userId).ToList().ForEach(r => _context.Tbl_UserRole.Remove(r));

            //Add New Roles
            AddRolesToUser(rolesId, userId);
        }

        public int AddRole(Tbl_Role role)
        {
            _context.Tbl_Role.Add(role);
            _context.SaveChanges();
            return role.Id;
        }

        public Tbl_Role GetRoleById(int roleId)
        {
            return _context.Tbl_Role.Find(roleId);
        }

        public void UpdateRole(Tbl_Role role)
        {
            _context.Tbl_Role.Update(role);
            _context.SaveChanges();
        }

        public void DeleteRole(Tbl_Role role)
        {
            role.IsDelete = true;
            UpdateRole(role);
        }

        public List<Tbl_Permission> GetAllPermission()
        {
            return _context.Tbl_Permission.ToList();
        }

        public void AddPermissionsToRole(int roleId, List<int> permission)
        {
            foreach (var p in permission)
            {
                _context.Tbl_RolePermission.Add(new Tbl_RolePermission()
                {
                    FK_Permission = p,
                    FK_Role = roleId
                });
            }

            _context.SaveChanges();
        }

        public List<int> PermissionsRole(int roleId)
        {
            return _context.Tbl_RolePermission
               .Where(r => r.FK_Role == roleId)
               .Select(r => r.FK_Permission).ToList();
        }

        public void UpdatePermissionsRole(int roleId, List<int> permissions)
        {
            _context.Tbl_RolePermission.Where(p => p.FK_Role == roleId)
                .ToList().ForEach(p => _context.Tbl_RolePermission.Remove(p));

            AddPermissionsToRole(roleId, permissions);
        }

        public bool CheckPermission(int permissionId, string userName)
        {
            int userId = _context.Tbl_User.Single(u => u.username == userName).Id;

            List<int> UserRoles = _context.Tbl_UserRole
                .Where(r => r.FK_User == userId).Select(r => r.FK_Role).ToList();

            if (!UserRoles.Any())
                return false;

            List<int> RolesPermission = _context.Tbl_RolePermission
                .Where(p => p.FK_Permission == permissionId)
                .Select(p => p.FK_Role).ToList();

            return RolesPermission.Any(p => UserRoles.Contains(p));
        }
    }
}
