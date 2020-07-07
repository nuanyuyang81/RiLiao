using System;

namespace RiLiao.Utility
{
    public class Logs
    {
        public int Id
        {
            get;set;
        }
        public string Action
        {
            get;set;
        }
        public string Table
        {
            get;set;
        }

        public string Message
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
    }
}
