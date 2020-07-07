using System;

namespace RiLiao.Utility
{
    public class FoodsPO
    {
        public int Id
        {
            get;set;
        }
        public double Amount
        {
            get;set;
        }
        public int VendorId
        {
            get;set;
        }
        public string Vendor
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
        public int WeekDay
        {
            get;set;
        }
        public DateTime CreateTime
        {
            get;set;
        }
    }
}
