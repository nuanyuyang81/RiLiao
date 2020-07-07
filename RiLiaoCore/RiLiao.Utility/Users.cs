using System;
using System.Collections.Generic;
using System.Text;

namespace RiLiao.Utility
{
    public class Users
    {
        public Guid Id
        {
            get;set;
        }
        public string UserName
        {
            get;set;
        }
        public string PhoneNumber
        {
            get;set;
        }
        public string PasswordHash
        {
            get;set;
        }
        public int RoleId
        {
            get;set;
        }

        public string Role
        {
            get;set;
        }

        public int AccessFailedCount
        {
            get;set;
        }
        public string SecurityStamp
        {
            get;set;
        }
    }
}
