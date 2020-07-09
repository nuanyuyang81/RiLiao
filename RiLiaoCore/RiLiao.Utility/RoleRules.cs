using System;

namespace RiLiao.Utility
{
    //角色权限规则
    public class RoleRules
    {
        // 角色权限规则记录唯一Id, 数据库自增长类型
        public int Id
        {
            get;set;
        }
        // 角色唯一Id
        public int RoleId
        {
            get;set;
        }
        // 角色权限
        public RolePermission Permission
        {
            get;set;
        }
        // 创建人员唯一Id
        public Guid OnwerId
        {
            get;set;
        }
        // 创建时间
        public DateTime CreateTime
        {
            get;set;
        }
        // 上次更新时间
        public DateTime LastUpdateTime
        {
            get;set;
        }
    }
}
