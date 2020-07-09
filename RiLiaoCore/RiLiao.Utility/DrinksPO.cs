using System;

namespace RiLiao.Utility
{
    // 酒水进货
    public class DrinksPO
    {
        // 酒水进货记录唯一Id, 数据库自增长类型
        public int Id
        {
            get;set;
        }
        // 进货金额
        public double Amount
        {
            get; set;
        }
        // 供应商唯一Id
        public int VendorId
        {
            get; set;
        }
        // 酒水进货录入人员唯一Id
        public Guid OwnerId
        {
            get; set;
        }
        // 酒水进货录入时间
        public DateTime CreateTime
        {
            get; set;
        }
    }
}
