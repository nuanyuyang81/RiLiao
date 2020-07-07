using System;

namespace RiLiao.Utility
{
    public class TurnOverTypes
    {
        public int Id
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }
        public Aim AimType
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
    public enum Aim
    {
        Foods = 0,
        Drinks = 1
    }
}
