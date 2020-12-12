using System;
using System.Collections.Generic;
using System.Text;
using Digitalogygroup.DataLayer.Entities.Permissions;
using Digitalogygroup.DataLayer.Entities.User;

namespace Digitalogygroup.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        #region Roles

        List<Tbl_Role> GetRoles();
        int AddRole(Tbl_Role role);
        Tbl_Role GetRoleById(int roleId);
        void UpdateRole(Tbl_Role role);
        void DeleteRole(Tbl_Role role);
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(int userId, List<int> rolesId);

        #endregion


        #region Permission

        List<Tbl_Permission> GetAllPermission();
        void AddPermissionsToRole(int roleId, List<int> permission);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> permissions);

        bool CheckPermission(int permissionId, string userName);

        #endregion
    }
}
