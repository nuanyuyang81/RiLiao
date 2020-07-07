using System;

namespace RiLiao.Utility
{
    public class Vendor
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
        public string Ower
        {
            get;set;
        }
        public string Comments
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
