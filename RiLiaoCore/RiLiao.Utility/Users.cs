using System;
using System.Collections.Generic;
using System.Text;

namespace RiLiao.Utility
{
    // 用户信息
    public class Users
    {
        // 用户信息
        public Guid Id
        {
            get;set;
        }
        // 用户是否处于正常使用状态
        public bool Active
        {
            get;set;
        }
        // 用户名
        public string UserName
        {
            get;set;
        }
        // 用户手机号码
        public string PhoneNumber
        {
            get;set;
        }
        // 用户密码，哈希加密
        public string PasswordHash
        {
            get;set;
        }
        // 用户角色唯一Id
        public int RoleId
        {
            get;set;
        }       
        // 登录失败次数
        public int AccessFailedCount
        {
            get;set;
        }
        // 添加用户时间
        public DateTime CreateTime
        {
            get;set;
        }
        // 用户上次登录时间
        public DateTime LastLoginTime
        {
            get;set;
        }
    }
}
