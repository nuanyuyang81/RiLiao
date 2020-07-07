using System;

namespace RiLiao.Utility
{
    public class Roles
    {
        public int Id
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }
        
        public Guid OwnerId
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
    }
}
