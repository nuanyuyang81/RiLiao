using System;

namespace RiLiao.Utility
{
    //用户角色
    public class Roles
    {
        // 用户角色唯一Id, 数据库自增长类型
        public int Id
        {
            get;set;
        }
        // 角色名称，admin / manager / staff
        public string Name
        {
            get;set;
        }
        // 角色创建人员唯一Id
        public Guid OwnerId
        {
            get;set;
        }
        // 创建时间
        public DateTime CreateTime
        {
            get;set;
        }
    }
}
