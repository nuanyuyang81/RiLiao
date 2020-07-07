using System;

namespace RiLiao.Utility
{
    public class RoleRules
    {
        public int Id
        {
            get;set;
        }
        public int RoleId
        {
            get;set;
        }
        public string RoleName
        {
            get;set;
        }
        public RolePermission Permission
        {
            get;set;
        }
        public string PermissionStr
        {
            get;set;
        }
        public Guid OnwerId
        {
            get;set;
        }
        public string Owner
        {
            get;set;
        }
        public DateTime CreateTime
        {
            get;set;
        }
        public DateTime LastUpdateTime
        {
            get;set;
        }
    }
}
